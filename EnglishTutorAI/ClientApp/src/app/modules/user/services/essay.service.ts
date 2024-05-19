import { Injectable } from '@angular/core';
import { Essay } from '../models/essay';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class EssayService {

  private apiUrl: string = "/api/essay";

  constructor(private httpClient: HttpClient) { }

  createEssay(newEssay: Essay): Observable<Essay> {
    return this.httpClient.post<Essay>(this.apiUrl, newEssay);
  }

  saveEssay(essayId: number, translatedText: string): Observable<Essay> {
    const body = JSON.stringify(translatedText);
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };
    return this.httpClient.put<Essay>(`${this.apiUrl}/${essayId}`, body, httpOptions);
  }

  getEssays(): Observable<Essay[]> {
    return this.httpClient.get<Essay[]>(this.apiUrl);
  }

  getLastDraft(): Observable<Essay> {
    return this.httpClient.get<Essay>(`${this.apiUrl}/getLastDraft`);
  }
  
  deleteEssay(essayId: number): Observable<void> {
    return this.httpClient.delete<void>(`${this.apiUrl}/${essayId}`);
  }
}
