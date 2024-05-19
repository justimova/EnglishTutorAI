import { TestBed } from '@angular/core/testing';

import { UserMenuItemsService } from './user-menu-items.service';

describe('UserMenuItemsService', () => {
  let service: UserMenuItemsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserMenuItemsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
