using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class Essay
{

	[Key]
    public int EssayId { get; set; }
	[Required]
	public DateTime CreationDate { get; set; }
	public DateTime? ModificationDate { get; set; }
	[Required]
	[DefaultValue(EssayStatus.Draft)]
	public EssayStatus Status { get; set; }
	[Required]
	[MaxLength(500)]
    public string Title { get; set; } = string.Empty;
	[Required]
	[MaxLength(1000)]
	public string BriefText { get; set; } = string.Empty;
	[Required]
	public string SourceText { get; set; } = string.Empty;
	public string? TranslatedText { get; set; } = string.Empty;
	public string? Recommendation { get; set; } = string.Empty;
	public ICollection<AiMessage> AiMessages { get; set; }

}

public enum EssayStatus {
	Draft,
	Done
}
