import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AsideNavPanelComponent } from './aside-nav-panel.component';

describe('AsideNavPanelComponent', () => {
  let component: AsideNavPanelComponent;
  let fixture: ComponentFixture<AsideNavPanelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AsideNavPanelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AsideNavPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
