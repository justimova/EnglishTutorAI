import { Component, Input } from '@angular/core';
import { Dictionary } from '../../models/dictionary';

@Component({
  selector: 'app-dictionary-view',
  templateUrl: './dictionary-view.component.html',
  styleUrls: ['./dictionary-view.component.scss']
})
export class DictionaryViewComponent {
  @Input() currentDictionary: Dictionary = new Dictionary();
  
  constructor() { }

}
