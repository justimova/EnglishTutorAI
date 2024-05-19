import { TestBed } from '@angular/core/testing';

import { LanguageLevelService } from './language-level.service';

describe('LanguageLevelService', () => {
  let service: LanguageLevelService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LanguageLevelService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
