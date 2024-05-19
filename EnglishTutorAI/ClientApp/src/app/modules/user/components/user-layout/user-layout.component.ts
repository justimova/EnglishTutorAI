import { Component, OnInit } from '@angular/core';
import { UserMenuItemsService } from '../../services/user-menu-items.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-layout',
  templateUrl: './user-layout.component.html',
  styleUrls: ['./user-layout.component.scss']
})
export class UserLayoutComponent implements OnInit {

  title: string = "";

  constructor(private userMenuItemsService: UserMenuItemsService,
    private router: Router) { }

  ngOnInit(): void {
    const currentRoute = this.router.url;
    this.title = this.userMenuItemsService.getTitleByRoute(currentRoute);
  }

}
