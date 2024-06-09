import { Injectable } from '@angular/core';
import { MenuItem } from '../models/menu-item';

@Injectable()
export class UserMenuItemsService {
  private menuItems;

  constructor() {
    this.menuItems = [
      { title: 'Dashboard', default: false, route: '/user/dashboard', icon: 'fa-tachometer', color: 'text-primary' },
      { title: 'Reading', default: false, route: '/user/training/reading', icon: 'fa-book', color: 'text-warning' },
      { title: 'Writing', default: false, route: '/user/training/writing', icon: 'fa-pencil', color: 'text-success' },
      { title: 'Grammar', default: false, route: '/user/training/grammar', icon: 'fa-graduation-cap', color: 'text-info' },
      { title: 'Dictionary', default: false, route: '/user/training/dictionary', icon: 'fa-folder-open', color: 'text-danger' }
    ];
  }
  getMenuItems(): MenuItem[] {
    return this.menuItems;
  }

  getTitleByRoute(route: string): string {
    if (route == '/user/profile') {
      return 'Profile';
    }
    return this.menuItems.find(menuItem => menuItem.route == route)?.title ?? "";
  }

}
