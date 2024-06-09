import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LoginModel } from '../../models/login-model';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {
  @ViewChild("newForm") newForm: NgForm | any = null;
  public loginModel: LoginModel;
  public errorMessage: string = '';

  constructor(private authService: AuthService, private router: Router) {
    this.loginModel = new LoginModel();
  }

  public onSubmit(): void {
    this.errorMessage = '';
    if (this.newForm?.valid) {
      this.authService.login(this.loginModel).subscribe(
        (_) => {
          this.router.navigateByUrl('/');
        },
        (errResponse) => {
          if (errResponse.status === 401) {
            this.errorMessage = errResponse.error.message;
          } else {
            this.errorMessage = 'Some error occurred during authorization';
          }
        });
    }
  }
}
