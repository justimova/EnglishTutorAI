import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-not-found',
  //standalone: true,
  templateUrl: './not-found.component.html',
  styleUrls: ['./not-found.component.css']
})
export class NotFoundComponent implements OnInit {
  public notFoundText: string = `404 SORRY COULDN'T FIND IT!!!`

  ngOnInit(): void {
    // TODO document why this method 'ngOnInit' is empty
  }

}