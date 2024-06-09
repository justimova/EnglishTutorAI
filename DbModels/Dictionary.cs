using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class Dictionary
{
	[Key]
	public int DictionaryId { get; set; }
	[Required]
	[MaxLength(1000)]
	public string Text { get; set; } = string.Empty;
	[Required]
	[MaxLength(1000)]
	public string TranslatedText { get; set; } = string.Empty;
	[MaxLength(1000)]
	public string Transcript { get; set; } = string.Empty;
	public string Examples { get; set; } = string.Empty;
	public string UserId { get; set; }
	public ApplicationUser User { get; set; }
}
