import { Component, OnInit } from '@angular/core';
import { BriefStatistic } from '../../models/brief-statistic';
import { StoryService } from '../../services/story.service';
import { EssayService } from '../../services/essay.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit
{
  briefStatistics: BriefStatistic[] = [];

  isRaiseDifferentTime(differentTime: number): boolean {
    return differentTime > 0;
  }
  isChangedDifferentTime(differentTime: number): boolean {
    return differentTime != 0;
  }

  constructor(private storyService: StoryService, private essayService: EssayService) {    
  }

  ngOnInit() {
    this.briefStatistics = [
      { code: 'reading', title: 'You\'ve already read texts:', spentTime: 0, icon: 'fa-book', color: 'text-info' },
      { code: 'writing', title: 'You\'ve already written essays:', spentTime: 0, icon: 'fa-pencil', color: 'text-warning' }
    ];
    this.storyService.getDoneStoryCount().subscribe(response => {
      this.briefStatistics[0].spentTime = response;
    });
    this.essayService.getDoneEssayCount().subscribe(response => {
      this.briefStatistics[1].spentTime = response;
    });
  }
}