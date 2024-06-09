import { Component, OnInit } from '@angular/core';
import { UserMenuItemsService } from '../../services/user-menu-items.service';
import { NavigationEnd, Router } from '@angular/router';
import { filter } from 'rxjs';

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
    this.initRoute();
    this.router.events.pipe(
      filter(event => event instanceof NavigationEnd)
    ).subscribe(() => {
      this.initRoute();
    });
  }

  private initRoute() {
    const currentRoute = this.router.url;
    this.title = this.userMenuItemsService.getTitleByRoute(currentRoute);
  }

}
