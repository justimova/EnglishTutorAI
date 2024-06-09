import { LanguageLevel } from "src/app/models/language-level";

export class RegistrationModel {
    public password: string = '';
    public confirmPassword: string = '';
    public email: string = '';
    public name: string = '';
    public languageLevel: LanguageLevel | null = null;
}
