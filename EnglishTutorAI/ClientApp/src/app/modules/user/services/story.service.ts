import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Story } from '../models/story';
import { Observable } from 'rxjs';

@Injectable()
export class StoryService {
  private apiUrl: string = "/api/story";

  constructor(private httpClient: HttpClient) { }

  getLastUnreadStory(): Observable<Story> {
    return this.httpClient.get<Story>(`${this.apiUrl}/getLastUnreadStory`);
  }

  createStory(newStory: Story): Observable<Story> {
    return this.httpClient.post<Story>(this.apiUrl, newStory);
  }

  setDoneStatus(storyId: number): Observable<Story> {
    return this.httpClient.put<Story>(`${this.apiUrl}/${storyId}`, 1);
  }

  getStories(): Observable<Story[]> {
    return this.httpClient.get<Story[]>(this.apiUrl);
  }

  deleteStory(storyId: number): Observable<void> {
    return this.httpClient.delete<void>(`${this.apiUrl}/${storyId}`);
  }

  getDoneStoryCount(): Observable<number> {
    return this.httpClient.get<number>(`${this.apiUrl}/getDoneStoryCount`);
  }

}
