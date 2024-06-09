import { Injectable } from '@angular/core';
import { LanguageLevel } from '../models/language-level';

@Injectable({
  providedIn: 'root'
})
export class GlobalVariablesService {
  private _titleSite: string = "English tutor";
  private _userLangLevel: LanguageLevel = new LanguageLevel();

  constructor() {
    this._userLangLevel.code = "A2";
    this._userLangLevel.languageLevelId = 2;
    this._userLangLevel.order = 2;
    this._userLangLevel.name = "Elementary";
  }
  

  getTitleSite(): string {
    return this._titleSite;
  }

  getUserLangLevel(): LanguageLevel {
    return this._userLangLevel;
  }
  
}
