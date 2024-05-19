import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Dictionary } from '../../models/dictionary';
import { DictionaryService } from '../../services/dictionary.service';

@Component({
  selector: 'app-dictionary-edit',
  templateUrl: './dictionary-edit.component.html',
  styleUrls: ['./dictionary-edit.component.scss']
})
export class DictionaryEditComponent implements OnInit {

  @Input() currentDictionary: Dictionary = new Dictionary();
  isSaving: boolean = false;
  @Output() edited = new EventEmitter<Dictionary>();

  constructor(private dictionaryService: DictionaryService) { }

  ngOnInit(): void {
  }

  onSave() {
    this.isSaving = true;
    this.dictionaryService.saveDictionary(this.currentDictionary).subscribe(response => {
      this.currentDictionary = response;
      this.isSaving = false;
      this.edited.emit(this.currentDictionary);
    });
  }
}
