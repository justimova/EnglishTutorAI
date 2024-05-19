import { Component, OnInit } from '@angular/core';
import { Story } from '../../models/story';
import { StoryService } from '../../services/story.service';
import { Subject } from 'rxjs';

declare var bootstrap: any;

@Component({
  selector: 'app-reading',
  templateUrl: './reading.component.html',
  styleUrls: ['./reading.component.scss']
})
export class ReadingComponent implements OnInit {

  currentStory: Story;
  isCurrentStoryLoading: boolean = false;
  isCurrentStoryLoaded: boolean = false;
  isCurrentStorySaving: boolean = false;
  refreshStoriesEvent: Subject<void> = new Subject<void>();

  constructor(private storyService: StoryService) { 
    this.currentStory = new Story();
  }

  ngOnInit(): void {
    this.isCurrentStoryLoading = true;
    this.storyService.getLastUnreadStory().subscribe((response) => {
      if (response == null) {
        this.createStory();
      } else {
        this.setCurrentStory(response);
      }
    });
  }

  setCurrentStory(story: Story): void {
    this.currentStory = story;
    this.isCurrentStoryLoaded = true;
    this.isCurrentStoryLoading = false;
  }

  createStory(): void {
    this.isCurrentStoryLoading = true;
    if (!this.isCurrentStoryLoaded) {
      this.storyService.createStory(this.currentStory).subscribe((response) => {
        this.setCurrentStory(response);
        this.refreshStories();
      });
    }
  }

  onDone() {
    this.isCurrentStorySaving = true;
    this.storyService.setDoneStatus(this.currentStory.storyId).subscribe((response) => {
      this.currentStory.status = 1;
      this.isCurrentStorySaving = false;
      this.refreshStories();
    });
  }

  showToast() {
    const toastEl = document.getElementById('liveToast');
    const toast = new bootstrap.Toast(toastEl, {
      autohide: true,
      delay: 5000
    });
    toast.show();
  }

  onCreateStory() {
    this.isCurrentStoryLoaded = false;
    this.currentStory = new Story();
    this.createStory();
  }

  onEditStoryClick(story: Story): void {
    this.isCurrentStoryLoading = true;
    this.setCurrentStory(story);
  }

  onViewStoryClick(story: Story): void {
    this.isCurrentStoryLoading = true;
    this.setCurrentStory(story);
  }

  onDeleteStoryClick(story: Story): void {
    this.storyService.deleteStory(story.storyId).subscribe((response) => {
      this.showToast();
      this.refreshStories();
    });
  }

  refreshStories(): void {
    this.refreshStoriesEvent.next();
  }

}
