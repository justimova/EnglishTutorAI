import { Component, OnInit } from '@angular/core';
import { DictionaryService } from '../../services/dictionary.service';
import { Dictionary } from '../../models/dictionary';

@Component({
  selector: 'app-dictionary',
  templateUrl: './dictionary.component.html',
  styleUrls: ['./dictionary.component.scss']
})
export class DictionaryComponent implements OnInit {
  isLoading: boolean = false;
  searchText: string = "";
  dictionaries: Dictionary[] = [];
  currentDictionary: Dictionary | null = null;
  isViewDictionary: boolean = false;
  viewDictionary: Dictionary = new Dictionary();
  editDictionary: Dictionary = new Dictionary();

  constructor(private dictionaryService: DictionaryService) { }

  ngOnInit(): void {
    this.loadDictionaries();
  }

  loadDictionaries() {
    this.currentDictionary = null;
    this.isLoading = true;
    this.dictionaryService.getAll(this.searchText).subscribe((response) => {
      this.dictionaries = response;
      this.isLoading = false;
    });
  }

  onAdd(): void {
    this.isViewDictionary = false;
    this.currentDictionary = new Dictionary();
    if (this.searchText != "") {
      this.currentDictionary.text = this.searchText;
    }
    this.editDictionary = this.currentDictionary;
  }

  onEdit(dictionary: Dictionary): void {
    this.isViewDictionary = false;
    this.currentDictionary = dictionary;
    this.editDictionary = this.currentDictionary;
  }

  onDelete(dictionary: Dictionary): void {
    if (dictionary != null) {
      if (dictionary.dictionaryId == this.currentDictionary?.dictionaryId) {
        this.currentDictionary = null;
      }
      this.dictionaryService.deleteDictionary(dictionary.dictionaryId).subscribe(response => {
        this.loadDictionaries();
        //alert("Word deleted successfully");
      });
    }
  }

  onView(dictionary: Dictionary): void {
    this.isViewDictionary = true;
    this.viewDictionary = dictionary ? dictionary : new Dictionary();
    this.currentDictionary = dictionary;
  }

  onSearch(): void {
    this.loadDictionaries();
  }

}
