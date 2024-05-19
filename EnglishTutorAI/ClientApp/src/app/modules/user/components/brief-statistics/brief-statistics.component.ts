import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'user-brief-statistics',
  templateUrl: './brief-statistics.component.html',
  styleUrls: ['./brief-statistics.component.scss']
})
export class BriefStatisticsComponent implements OnInit {

  @Input() briefStatistic: any = null;
  constructor() {
  }

  ngOnInit(): void {
  }

}
