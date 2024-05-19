import { Component, OnInit, ViewChild } from '@angular/core';
import { Essay } from '../../models/essay';
import { EssayService } from '../../services/essay.service';
import { NgForm } from '@angular/forms';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-writing',
  templateUrl: './writing.component.html',
  styleUrls: ['./writing.component.scss']
})
export class WritingComponent implements OnInit {

  currentEssay: Essay;
  isCurrentEssayLoading: boolean = false;
  isCurrentEssayLoaded: boolean = false;
  isCurrentEssayTranslated: boolean = false;
  isCurrentEssayTranslating: boolean = false;
  translatedText: string = "";
  safeRecommendation: SafeHtml;
  @ViewChild("newForm") newForm: NgForm | any = null;
  refreshEssaysEvent: Subject<void> = new Subject<void>();
  
  constructor(private essayService: EssayService, private sanitizer: DomSanitizer) {
    this.currentEssay = new Essay();
    this.safeRecommendation = this.sanitizer.bypassSecurityTrustHtml('');
  }

  ngOnInit(): void {
    this.isCurrentEssayLoading = true;
    this.essayService.getLastDraft().subscribe((response) => {
      if (response == null) {
        this.createEssay();
      } else {
        this.setCurrentEssay(response);
      }
    });
  }

  refreshEssays(): void {
    this.refreshEssaysEvent.next();
  }

  onTranslate(): void {
    if (this.newForm.valid) {
      this.isCurrentEssayTranslating = true;
      this.currentEssay.translatedText = this.translatedText;
      this.essayService.saveEssay(this.currentEssay?.essayId, this.currentEssay.translatedText).subscribe((response) => {
        if (response != null && response.recommendation != null) {
          this.safeRecommendation = this.sanitizer.bypassSecurityTrustHtml(response.recommendation + '');
        }
        this.currentEssay = response;
        this.isCurrentEssayTranslated = true;
        this.isCurrentEssayTranslating = false;
        this.refreshEssays();
      });
    }
  }

  hasCurrentRecommendation(): boolean {
    return this.isCurrentEssayTranslated;
  }

  onEditEssayClick(essay: Essay): void {
    this.isCurrentEssayLoading = true;
    this.isCurrentEssayTranslated = false;
    this.setCurrentEssay(essay);
  }

  onViewEssayClick(essay: Essay): void {
    this.isCurrentEssayLoading = true;
    this.setCurrentEssay(essay);
    this.isCurrentEssayTranslated = true;
  }

  setCurrentEssay(essay: Essay): void {
    this.currentEssay = essay;
    this.newForm.resetForm();
    this.isCurrentEssayLoaded = true;
    this.isCurrentEssayLoading = false;
    this.safeRecommendation = this.sanitizer.bypassSecurityTrustHtml(essay.recommendation + '');
  }

  onCreateEssay(): void {
    this.isCurrentEssayLoaded = false;
    this.isCurrentEssayTranslated = false;
    this.currentEssay = new Essay();
    this.createEssay();
  }

  createEssay(): void {
    this.isCurrentEssayLoading = true;
    if (!this.isCurrentEssayLoaded) {
      this.essayService.createEssay(this.currentEssay).subscribe((response) => {
        this.setCurrentEssay(response);
        this.refreshEssays();
      });
    }
  }
}
