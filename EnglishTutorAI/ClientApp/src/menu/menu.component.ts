import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  //standalone: true,
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  isCollapsed: boolean = false;
  public nameCompany: string = "English AI Tutor";
  
  ngOnInit(): void {
  }

}