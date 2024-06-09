import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { RegistrationModel } from '../../models/registraion-model';
import { LanguageLevel } from 'src/app/models/language-level';
import { LanguageLevelService } from 'src/app/services/language-level.service';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.scss'
})
export class SignupComponent implements OnInit {
  @ViewChild("newForm") newForm: NgForm | any = null;
  public registrationModel: RegistrationModel;
  public errorMessage: string = '';
  langLevels: LanguageLevel[] = [];

  constructor(private languageLevelService: LanguageLevelService, private authService: AuthService,
      private router: Router) {
    this.registrationModel = new RegistrationModel();
    
  }

  public ngOnInit(): void {
    this.languageLevelService.getLanguageLevels().subscribe(response => {
      this.langLevels = response;
      this.registrationModel.languageLevel = this.langLevels[0];
    });
  }

  public onSubmit(): void {
    this.errorMessage = '';
    if (this.newForm?.valid) {
      this.authService.register(this.registrationModel).subscribe(
        (_) => {
          this.router.navigate(['/login']);
        },
        (errResponse) => {
          if (errResponse.status === 401) {
            this.errorMessage = errResponse.error.message;
          } else {
            if (errResponse?.error.length > 0) {
              this.errorMessage = errResponse.error.map((err: any) => err.description).join(' ');
            } else {
              this.errorMessage = 'Some error occurred during registration';
            }
          }
        });
    }
  }

  onSelectLevel(langLevel: LanguageLevel): void {
    this.registrationModel.languageLevel = langLevel;
  }
}
