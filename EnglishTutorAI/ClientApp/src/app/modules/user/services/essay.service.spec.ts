import { TestBed } from '@angular/core/testing';

import { EssayService } from './essay.service';

describe('EssayService', () => {
  let service: EssayService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EssayService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
