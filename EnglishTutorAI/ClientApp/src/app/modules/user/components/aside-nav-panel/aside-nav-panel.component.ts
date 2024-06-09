import { Component, Inject, OnInit } from '@angular/core';
import { MenuItem } from '../../models/menu-item';
import { GlobalVariablesService } from 'src/app/services/global-variables.service';
import { NavigationEnd, Router } from '@angular/router';
import { UserMenuItemsService } from '../../services/user-menu-items.service';
import { AuthService } from 'src/app/modules/auth/services/auth.service';
import { filter } from 'rxjs';


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
    private userMenuItemsService: UserMenuItemsService,
    private authService: AuthService) { }

  private initUserMenuItems(): void {
    this.userMenuItems = this.userMenuItemsService.getMenuItems();
    this.setDefaultItem();
  }

  private setDefaultItem() {
    const currentRoute = this.router.url;
    this.userMenuItems.forEach(menuItem => {
      menuItem.default = menuItem.route == currentRoute;
    });
  }

  ngOnInit(): void {
    this.title = this.globalVariablesService.getTitleSite();
    this.initUserMenuItems();
    this.router.events.pipe(
      filter(event => event instanceof NavigationEnd)
    ).subscribe(() => {
      this.setDefaultItem();
    });
  }

  public logout() {
    this.authService.logout();
  }
}
