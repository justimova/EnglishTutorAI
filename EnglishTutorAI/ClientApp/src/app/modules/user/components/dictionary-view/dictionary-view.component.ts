import { Component, Input, OnInit } from '@angular/core';
import { Dictionary } from '../../models/dictionary';

@Component({
  selector: 'app-dictionary-view',
  templateUrl: './dictionary-view.component.html',
  styleUrls: ['./dictionary-view.component.scss']
})
export class DictionaryViewComponent implements OnInit {

  @Input() currentDictionary: Dictionary = new Dictionary();
  
  constructor() { }

  ngOnInit(): void {
  }

}
