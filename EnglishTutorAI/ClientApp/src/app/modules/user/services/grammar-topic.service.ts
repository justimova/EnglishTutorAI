import { Injectable } from '@angular/core';
import { GrammarTopic } from '../models/grammar-topic';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class GrammarTopicService {
  private apiUrl: string = "/api/grammarTopic";

  constructor(private httpClient: HttpClient) { }

  getGrammarTopics(): Observable<GrammarTopic[]> {
    return this.httpClient.get<GrammarTopic[]>(this.apiUrl);
  }
  
}
