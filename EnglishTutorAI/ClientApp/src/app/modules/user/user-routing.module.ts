import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { UserLayoutComponent } from './components/user-layout/user-layout.component';
import { TrainingComponent } from './components/training/training.component';
import { WritingComponent } from './components/writing/writing.component';
import { ReadingComponent } from './components/reading/reading.component';
import { DictionaryComponent } from './components/dictionary/dictionary.component';
import { GrammarComponent } from './components/grammar/grammar.component';

const routes: Routes = [
  {
    path: '',
    component: UserLayoutComponent,
    children: [
      { path: '', redirectTo: 'training/dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'training', redirectTo: 'training/dashboard', pathMatch: 'full' },
      { path: 'training/reading', component: ReadingComponent },
      { path: 'training/writing', component: WritingComponent },
      { path: 'training/grammar', component: GrammarComponent },
      { path: 'training/dictionary', component: DictionaryComponent }
    ]
  }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class UserRoutingModule { }
