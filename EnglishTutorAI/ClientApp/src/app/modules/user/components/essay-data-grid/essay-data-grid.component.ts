import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { EssayService } from '../../services/essay.service';
import { Essay } from '../../models/essay';
import { Subject, Subscription } from 'rxjs';

declare var bootstrap: any;

@Component({
  selector: 'app-essay-data-grid',
  templateUrl: './essay-data-grid.component.html',
  styleUrls: ['./essay-data-grid.component.scss']
})
export class EssayDataGridComponent implements OnInit {

  essays: Essay[] = [];
  @Output() editClick = new EventEmitter<Essay>();
  @Output() viewClick = new EventEmitter<Essay>();
  @Input() refreshEssaysEvent!: Subject<void>;
  private subscriptionRefreshEssaysEvent!: Subscription;
  @Input() currentEssay: Essay | null = null;
  
  constructor(private essayService: EssayService) { }

  ngOnInit(): void {
    this.refreshEssays();
    this.subscriptionRefreshEssaysEvent = this.refreshEssaysEvent.subscribe(() => {
      this.refreshEssays();
    });
  }

  ngOnDestroy() {
    if (this.subscriptionRefreshEssaysEvent) {
      this.subscriptionRefreshEssaysEvent.unsubscribe();
    }
  }

  refreshEssays(): void {
    this.essayService.getEssays().subscribe((response) => {
      this.essays = response;
    });
  }
  
  getFormattingDate(date: Date | string | null) {
    if (date == null) {
      return '';
    }
    return new Date(date).toLocaleDateString();
  }

  getFormattingDateTime(date: Date | string | null) {
    if (date == null) {
      return '';
    }
    date = new Date(date);
    return `${date.toLocaleDateString()} ${date.toLocaleTimeString()}`;
  }

  onEditEssay(essay: Essay): void {
    this.editClick.emit(essay);
  }

  onViewEssay(essay: Essay): void {
    this.viewClick.emit(essay);
  }

  onDeleteEssay(essay: Essay): void {
    this.essayService.deleteEssay(essay.essayId).subscribe((response) => {
      this.showToast();
      this.refreshEssays();
    });
  }

  showToast() {
    const toastEl = document.getElementById('liveToast');
    const toast = new bootstrap.Toast(toastEl, {
      autohide: true,
      delay: 5000
    });
    toast.show();
  }

}
