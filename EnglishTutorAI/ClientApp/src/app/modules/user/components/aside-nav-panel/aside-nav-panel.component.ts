import { Component, Inject, OnInit } from '@angular/core';
import { MenuItem } from '../../models/menu-item';
import { GlobalVariablesService } from 'src/app/services/global-variables.service';
import { Router } from '@angular/router';
import { UserMenuItemsService } from '../../services/user-menu-items.service';


@Component({
  selector: 'user-aside-nav-panel',
  templateUrl: './aside-nav-panel.component.html',
  styleUrls: ['./aside-nav-panel.component.scss']
})
export class AsideNavPanelComponent implements OnInit {
  userMenuItems: MenuItem[] = [];
  title: string = "";

  constructor(private globalVariablesService: GlobalVariablesService,
    private router: Router,
    private userMenuItemsService: UserMenuItemsService) { }

  private initUserMenuItems(): void {
    const currentRoute = this.router.url;
    this.userMenuItems = this.userMenuItemsService.getMenuItems();
    this.userMenuItems.forEach(menuItem => {
      menuItem.default = menuItem.route == currentRoute;
    });
  }

  ngOnInit(): void {
    this.title = this.globalVariablesService.getTitleSite();
    this.initUserMenuItems();
  }
}
