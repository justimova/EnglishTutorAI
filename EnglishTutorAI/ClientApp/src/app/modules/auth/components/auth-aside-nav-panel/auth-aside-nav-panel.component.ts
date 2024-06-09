import { Component, OnInit } from '@angular/core';
import { GlobalVariablesService } from 'src/app/services/global-variables.service';

@Component({
  selector: 'app-auth-aside-nav-panel',
  templateUrl: './auth-aside-nav-panel.component.html',
  styleUrl: './auth-aside-nav-panel.component.scss'
})
export class AuthAsideNavPanelComponent implements OnInit {
  public title: string = "";

  constructor(private globalVariablesService: GlobalVariablesService) { }

  public ngOnInit(): void {
    this.title = this.globalVariablesService.getTitleSite();
  }

}
