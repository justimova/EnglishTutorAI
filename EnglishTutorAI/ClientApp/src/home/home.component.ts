import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  //standalone: true,
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public homeText: string;

  ngOnInit(): void {
    this.homeText = "WELCOME TO YOUR PERSONAL ENGLISH AI TUTOR";
  }

}