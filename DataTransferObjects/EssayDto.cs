namespace DataTransferObjects;

public class EssayDto
{
    public int EssayId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string BriefText { get; set; } = string.Empty;
    public string SourceText { get; set; } = string.Empty;
    public string? TranslatedText { get; set; } = string.Empty;
    public string? Recommendation { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
    public DateTime? ModificationDate { get; set; }
    public int Status { get; set; } = 0;
}
