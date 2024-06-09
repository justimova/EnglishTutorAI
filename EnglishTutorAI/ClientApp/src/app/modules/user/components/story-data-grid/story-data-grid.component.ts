import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Story } from '../../models/story';
import { StoryService } from '../../services/story.service';
import { Subject, Subscription } from 'rxjs';

@Component({
  selector: 'app-story-data-grid',
  templateUrl: './story-data-grid.component.html',
  styleUrls: ['./story-data-grid.component.scss']
})
export class StoryDataGridComponent implements OnInit {
  stories: Story[] = [];
  @Input() currentStory: Story | null = null;
  @Output() viewClick = new EventEmitter<Story>();
  @Output() editClick = new EventEmitter<Story>();
  @Output() deleteClick = new EventEmitter<Story>();
  @Input() refreshStoriesEvent!: Subject<void>;
  private subscriptionRefreshStoriesEvent!: Subscription;

  constructor(private storyService: StoryService) { }

  ngOnInit(): void {
    this.refreshStories();
    this.subscriptionRefreshStoriesEvent = this.refreshStoriesEvent.subscribe(() => {
      this.refreshStories();
    });
  }

  ngOnDestroy() {
    if (this.subscriptionRefreshStoriesEvent) {
      this.subscriptionRefreshStoriesEvent.unsubscribe();
    }
  }

  refreshStories(): void {
    this.storyService.getStories().subscribe((response) => {
      this.stories = response;
    });
  }

  getFormattingDateTime(date: Date | string | null) {
    if (date == null) {
      return '';
    }
    date = new Date(date);
    return `${date.toLocaleDateString()} ${date.toLocaleTimeString()}`;
  }

  onViewStory(story: Story): void {
    this.viewClick.emit(story);
  }

  onEditStory(story: Story): void {
    this.editClick.emit(story);
  }

  onDeleteStory(story: Story): void {
    this.deleteClick.emit(story);
  }
}
