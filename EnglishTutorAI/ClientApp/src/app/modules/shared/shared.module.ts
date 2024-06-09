import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SignNumberPipe } from './utils/sign-number.pipe';

@NgModule({
  declarations: [
    SignNumberPipe
  ],
  imports: [
    CommonModule
  ],
  exports: [
    SignNumberPipe
  ]
})
export class SharedModule { }
