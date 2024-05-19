namespace DataTransferObjects.Reading;

public class StoryParagraphDto
{
	public int StoryParagraphId { get; set; }
	public string Text { get; set; } = string.Empty;
	public string TranslatedText { get; set; } = string.Empty;
	public int Order { get; set; } = 0;
}
