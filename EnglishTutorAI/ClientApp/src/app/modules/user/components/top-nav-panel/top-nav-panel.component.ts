import { Component, OnInit } from '@angular/core';
import { UserMenuItemsService } from '../../services/user-menu-items.service';
import { Router } from '@angular/router';

@Component({
  selector: 'user-top-nav-panel',
  templateUrl: './top-nav-panel.component.html',
  styleUrls: ['./top-nav-panel.component.scss']
})
export class TopNavPanelComponent implements OnInit {

  title: string = "";
  constructor(private userMenuItemsService: UserMenuItemsService,
    private router: Router) { }

  ngOnInit(): void {
    const currentRoute = this.router.url;
    this.title = this.userMenuItemsService.getTitleByRoute(currentRoute);
  }

}
