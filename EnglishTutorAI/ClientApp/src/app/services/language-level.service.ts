import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LanguageLevel } from '../models/language-level';
import { Observable } from 'rxjs';

@Injectable()
export class LanguageLevelService {

  apiUrl: string = "/api/languageLevel";

  constructor(private httpClient: HttpClient) {
  }

  getLanguageLevels(): Observable<LanguageLevel[]> {
    return this.httpClient.get<LanguageLevel[]>(this.apiUrl);
  }
}
