import { StoryParagraph } from "./story-paragraph";

export class Story {
    storyId: number = 0;
    creationDate: Date = new Date();
    modificationDate: Date | null = null;
    status: number = 0;
    title: string = "";
    paragraphs: StoryParagraph[] = [];
}
