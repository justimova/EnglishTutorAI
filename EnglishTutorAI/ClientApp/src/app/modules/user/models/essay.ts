export class Essay {
    essayId: number = 0;
    title: string = "";
    briefText: string = "";
    sourceText: string = "";
    translatedText: string | null = "";
    creationDate: Date = new Date();
    modificationDate: Date | null = null;
    recommendation: string | null = "";
    status: number = 0;
}
