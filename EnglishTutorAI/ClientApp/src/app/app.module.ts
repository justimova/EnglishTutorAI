import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GlobalVariablesService } from './services/global-variables.service';
import { LanguageLevelService } from './services/language-level.service';
import { DropdownModule } from 'primeng/dropdown';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { EditorModule } from 'primeng/editor';
import { AuthModule } from './modules/auth/auth.module';
import { AuthRoutingModule } from './modules/auth/auth-routing.module';

@NgModule({
  declarations: [ AppComponent ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule, 
    DropdownModule,
    FormsModule,
    BrowserAnimationsModule,
    InputTextareaModule,
    EditorModule,
    AuthModule,
    AuthRoutingModule
  ],
  providers: [
    GlobalVariablesService,
    LanguageLevelService,
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {}
