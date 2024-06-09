import { Component, OnInit } from '@angular/core';
import { GlobalVariablesService } from 'src/app/services/global-variables.service';
import { GrammarTopicService } from '../../services/grammar-topic.service';
import { GrammarTopic } from '../../models/grammar-topic';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { LanguageLevel } from 'src/app/models/language-level';
import { LanguageLevelService } from 'src/app/services/language-level.service';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-grammar',
  templateUrl: './grammar.component.html',
  styleUrls: ['./grammar.component.scss']
})
export class GrammarComponent implements OnInit {
  grammarTopics: GrammarTopic[] = [];
  isLoading: boolean = false;
  currentGrammarTopic: GrammarTopic | null = null;
  safeRecommendation: SafeHtml;
  langLevels: LanguageLevel[] = [];
  userLangLevel: LanguageLevel | null = null;
  currentLangLevel: LanguageLevel | null = null;

  constructor(private globalVariablesService: GlobalVariablesService,
      private grammarTopicService: GrammarTopicService,
      private sanitizer: DomSanitizer,
      private languageLevelService: LanguageLevelService,
      private accountService: AccountService) {
    this.userLangLevel = this.globalVariablesService.getUserLangLevel();
    this.currentLangLevel = this.userLangLevel;
    this.safeRecommendation = this.sanitizer.bypassSecurityTrustHtml('');
  }

  ngOnInit(): void {
    this.grammarTopicService.getGrammarTopics().subscribe(response => {
      this.grammarTopics = response;
    });
    this.languageLevelService.getLanguageLevels().subscribe(response => {
      this.langLevels = response;
      this.accountService.getCurrentUser().subscribe(response => {
        this.currentLangLevel = this.langLevels.find(x => x.languageLevelId == response.languageLevelId)!!;
      });
    });
  }

  onView(grammarTopic: GrammarTopic) {
    this.currentGrammarTopic = grammarTopic;
    this.safeRecommendation = '';
    if (this.currentGrammarTopic != null && this.currentGrammarTopic.explanation != null) {
      this.safeRecommendation = this.sanitizer.bypassSecurityTrustHtml(this.currentGrammarTopic?.explanation + '');
    }
  }

  onSelectLevel(langLevel: LanguageLevel): void {
    this.currentLangLevel = langLevel;
  }

  getGrammarTopicsByCurrentLangLevel(): GrammarTopic[] {
    return this.grammarTopics?.filter(x => x.languageLevelId == this.currentLangLevel?.languageLevelId);
  }

}
