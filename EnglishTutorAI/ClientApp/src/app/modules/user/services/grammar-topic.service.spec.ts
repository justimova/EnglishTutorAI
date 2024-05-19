import { TestBed } from '@angular/core/testing';

import { GrammarTopicService } from './grammar-topic.service';

describe('GrammarTopicService', () => {
  let service: GrammarTopicService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GrammarTopicService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
