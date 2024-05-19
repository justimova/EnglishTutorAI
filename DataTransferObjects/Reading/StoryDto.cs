namespace DataTransferObjects.Reading;

public class StoryDto
{
	public int StoryId { get; set; }
	public DateTime CreationDate { get; set; }
	public DateTime? ModificationDate { get; set; }
	public int Status { get; set; } = 0;
	public string Title { get; set; } = string.Empty;
	public IEnumerable<StoryParagraphDto> Paragraphs { get; set; }
}
