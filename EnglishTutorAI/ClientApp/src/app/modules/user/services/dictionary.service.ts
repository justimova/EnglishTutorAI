import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Dictionary } from '../models/dictionary';
import { Observable } from 'rxjs';

@Injectable()
export class DictionaryService {

  private apiUrl: string = "/api/dictionary";

  constructor(private httpClient: HttpClient) { }

  getAll(search: string | null): Observable<Dictionary[]> {
    if (search != null && search != "") {
      return this.httpClient.get<Dictionary[]>(`${this.apiUrl}/searchDictionaries/${search}`);
    }
    return this.httpClient.get<Dictionary[]>(`${this.apiUrl}/${search}`);
  }

  saveDictionary(dictionary: Dictionary): Observable<Dictionary> {
    if (dictionary.dictionaryId == 0) {
      return this.httpClient.post<Dictionary>(this.apiUrl, dictionary);
    }
    return this.httpClient.put<Dictionary>(this.apiUrl, dictionary);
  }

  deleteDictionary(dictionaryId: number): Observable<void> {
    return this.httpClient.delete<void>(`${this.apiUrl}/${dictionaryId}`);
  }

}
