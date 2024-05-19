import { Component, OnInit } from '@angular/core';
import { BriefStatistic } from '../../models/brief-statistic';

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

  ngOnInit() {
    this.briefStatistics = [
      { title: 'Texts Read', spentTime: 50, differentTime: 2 },
      { title: 'Essays Written', spentTime: 35, differentTime: -8 },
      { title: 'Grammar Rules Learned', spentTime: 50, differentTime: 0 },
      { title: 'Grammar Exercises', spentTime: 108, differentTime: 20 },
    ];
  }
}