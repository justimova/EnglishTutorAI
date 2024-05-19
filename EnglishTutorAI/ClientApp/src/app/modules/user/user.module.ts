import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserLayoutComponent } from './components/user-layout/user-layout.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { UserRoutingModule } from './user-routing.module';
import { TrainingComponent } from './components/training/training.component';
import { AsideNavPanelComponent } from './components/aside-nav-panel/aside-nav-panel.component';
import { UserMenuItemsService } from './services/user-menu-items.service';
import { TopNavPanelComponent } from './components/top-nav-panel/top-nav-panel.component';
import { DashboardService } from './services/dashboard.service';
import { BriefStatisticsComponent } from './components/brief-statistics/brief-statistics.component';
import { SharedModule } from '../shared/shared.module';
import { WritingComponent } from './components/writing/writing.component';
import { EssayService } from './services/essay.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { EssayDataGridComponent } from './components/essay-data-grid/essay-data-grid.component';
import { ReadingComponent } from './components/reading/reading.component';
import { StoryService } from './services/story.service';
import { StoryDataGridComponent } from './components/story-data-grid/story-data-grid.component';
import { DictionaryComponent } from './components/dictionary/dictionary.component';
import { DictionaryService } from './services/dictionary.service';
import { DictionaryViewComponent } from './components/dictionary-view/dictionary-view.component';
import { DictionaryEditComponent } from './components/dictionary-edit/dictionary-edit.component';
import { GrammarComponent } from './components/grammar/grammar.component';
import { GrammarTopicService } from './services/grammar-topic.service';

@NgModule({
  declarations: [
    UserLayoutComponent,
    DashboardComponent,
    TrainingComponent,
    AsideNavPanelComponent,
    TopNavPanelComponent,
    BriefStatisticsComponent,
    WritingComponent,
    EssayDataGridComponent,
    ReadingComponent,
    StoryDataGridComponent,
    DictionaryComponent,
    DictionaryViewComponent,
    DictionaryEditComponent,
    GrammarComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule,
    SharedModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    UserMenuItemsService,
    DashboardService,
    EssayService,
    StoryService,
    DictionaryService,
    GrammarTopicService
  ]
})
export class UserModule { }
