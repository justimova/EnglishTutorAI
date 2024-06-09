import { Injectable } from '@angular/core';

@Injectable()
export class DashboardService {
  private title: string = "Dashboard";

  getTitle(): string {
    return this.title;
  }
  
}
