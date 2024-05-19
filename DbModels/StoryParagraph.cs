using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class StoryParagraph
{
	[Key]
	public int StoryParagraphId { get; set; }
	[Required]
	public string Text { get; set; } = string.Empty;
	[Required]
	public string TranslatedText { get; set; } = string.Empty;
	[Required]
	[DefaultValue(0)]
	public int Order { get; set; }
	[Required]
	public int StoryId { get; set; }
	public Story Story { get; set; }
}
