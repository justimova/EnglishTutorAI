import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DashboardComponent } from './components/dashboard/dashboard.component';
import { UserLayoutComponent } from './components/user-layout/user-layout.component';
import { WritingComponent } from './components/writing/writing.component';
import { ReadingComponent } from './components/reading/reading.component';
import { DictionaryComponent } from './components/dictionary/dictionary.component';
import { GrammarComponent } from './components/grammar/grammar.component';
import { AuthGuard } from './services/auth.guard';
import { UserProfileComponent } from './components/user-profile/user-profile.component';

const routes: Routes = [
  {
    path: '',
    component: UserLayoutComponent,
    children: [
      { path: '', redirectTo: 'training/dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard] },
      { path: 'training', redirectTo: 'training/dashboard', pathMatch: 'full' },
      { path: 'training/reading', component: ReadingComponent, canActivate: [AuthGuard] },
      { path: 'training/writing', component: WritingComponent, canActivate: [AuthGuard] },
      { path: 'training/grammar', component: GrammarComponent, canActivate: [AuthGuard] },
      { path: 'training/dictionary', component: DictionaryComponent, canActivate: [AuthGuard] },
      { path: 'profile', component: UserProfileComponent, canActivate: [AuthGuard] },
    ]
  }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class UserRoutingModule { }
