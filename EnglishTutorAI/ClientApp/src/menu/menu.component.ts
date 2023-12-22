import { Component, OnInit } from '@angular/core';
import { MenuItem } from '../_interfaces/menu/menu-item';
@Component({
  selector: 'app-menu',
  //standalone: true,
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  isCollapsed: boolean = false;
  public nameCompany: string = "English AI Tutor";
  menuItems: MenuItem[] = [{
    name: 'Dashboard',
    route: '/dashboard',
    isActive: true
  }, {
    name: 'Grammar',
    route: '/grammar',
    isActive: false
  }, {
    name: 'Reading',
    route: '/reading',
    isActive: false
  }, {
    name: 'Writing',
    route: '/writing',
    isActive: false
  }, {
    name: 'My Profile',
    route: '/profile',
    isActive: false
  }];

  ngOnInit(): void {
  }

}