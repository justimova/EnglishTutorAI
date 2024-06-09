import { LanguageLevel } from "src/app/models/language-level";

export class ApplicationUser {
    public email: string = '';
    public firstName: string = '';
    public languageLevelId: number | null = null;
    public languageLevel: LanguageLevel | undefined;
}