namespace DataTransferObjects.Grammar;

public class GrammarTopicDto
{
	public int GrammarTopicId { get; set; }
	public string Text { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public int LanguageLevelId { get; set; }
	public int Order { get; set; } = 0;
	public string Explanation { get; set; } = string.Empty;
}
