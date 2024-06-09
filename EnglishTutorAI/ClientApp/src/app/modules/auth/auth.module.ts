import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthLayoutComponent } from './components/auth-layout/auth-layout.component';
import { LoginComponent } from './components/login/login.component';
import { AuthRoutingModule } from './auth-routing.module';
import { AuthAsideNavPanelComponent } from './components/auth-aside-nav-panel/auth-aside-nav-panel.component';
import { FormsModule } from '@angular/forms';
import { EditorModule } from 'primeng/editor';
import { SignupComponent } from './components/signup/signup.component';

@NgModule({
  declarations: [
    AuthLayoutComponent,
    LoginComponent,
    SignupComponent,
    AuthAsideNavPanelComponent
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    FormsModule,
    EditorModule,
  ]
})
export class AuthModule { }
