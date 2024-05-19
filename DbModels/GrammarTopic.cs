using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class GrammarTopic
{
	[Key]
	public int GrammarTopicId { get; set; }
	[Required]
	[MaxLength(1500)]
	public string Text { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	[Required]
	public int LanguageLevelId { get; set; }
	public LanguageLevel LanguageLevel { get; set; }
	[Required]
	public int Order { get; set; } = 0;
	public string Explanation { get; set; } = string.Empty;
}

