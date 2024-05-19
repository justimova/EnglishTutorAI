import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { GlobalVariablesService } from './services/global-variables.service';
import { ConfirmationModalComponent } from './confirmation-modal/confirmation-modal.component';
import { LanguageLevelService } from './services/language-level.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [ AppComponent, AboutComponent, ConfirmationModalComponent ],
  imports: [ BrowserModule, AppRoutingModule, HttpClientModule ],
  providers: [ GlobalVariablesService, LanguageLevelService ],
  bootstrap: [ AppComponent ],
})
export class AppModule {}
