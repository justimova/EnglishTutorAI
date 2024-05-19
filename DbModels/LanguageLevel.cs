using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class LanguageLevel
{
	[Key]
	public int LanguageLevelId { get; set; }
	[Required]
	[MaxLength(20)]
	public string Code { get; set; } = string.Empty;
	[Required]
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;
	[Required]
	public string Description { get; set; } = string.Empty;
	[Required]
	public int Order { get; set; } = 0;
}
