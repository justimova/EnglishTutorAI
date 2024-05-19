import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StoryDataGridComponent } from './story-data-grid.component';

describe('StoryDataGridComponent', () => {
  let component: StoryDataGridComponent;
  let fixture: ComponentFixture<StoryDataGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StoryDataGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StoryDataGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
