import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EssayDataGridComponent } from './essay-data-grid.component';

describe('EssayDataGridComponent', () => {
  let component: EssayDataGridComponent;
  let fixture: ComponentFixture<EssayDataGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EssayDataGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EssayDataGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
