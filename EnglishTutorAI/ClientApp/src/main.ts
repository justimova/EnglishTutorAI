import { bootstrapApplication } from "@angular/platform-browser";
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppComponent } from "./app/app.component";
import { AppModule } from './app/app.module';

bootstrapApplication(AppComponent).catch(e => console.error(e));
platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));