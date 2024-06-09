import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LanguageLevel } from 'src/app/models/language-level';
import { ApplicationUser } from 'src/app/modules/auth/models/application-user';
import { LanguageLevelService } from 'src/app/services/language-level.service';
import { AccountService } from '../../services/account.service';

declare var bootstrap: any;

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.scss'
})
export class UserProfileComponent implements OnInit {
  @ViewChild("newForm") newForm: NgForm | any = null;
  public userModel: ApplicationUser;
  langLevels: LanguageLevel[] = [];

  constructor(private languageLevelService: LanguageLevelService, private accountService: AccountService) {
      this.userModel = new ApplicationUser();
    }

  public ngOnInit(): void {
    this.languageLevelService.getLanguageLevels().subscribe(response => {
      this.langLevels = response;
    });
    this.accountService.getCurrentUser().subscribe(response => {
      this.userModel = response;
      this.userModel.languageLevel = this.langLevels.find(x => x.languageLevelId == this.userModel?.languageLevelId);
    })
  }

  onSubmit() {
    this.accountService.saveCurrentUser(this.userModel).subscribe((response) => {
      this.showToast();
    });
  }

  onSelectLevel(langLevel: LanguageLevel): void {
    this.userModel.languageLevel = langLevel;
    this.userModel.languageLevelId = langLevel.languageLevelId;
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
