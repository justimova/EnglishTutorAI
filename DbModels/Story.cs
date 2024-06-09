using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class Story
{
	[Key]
	public int StoryId { get; set; }
	[Required]
	public DateTime CreationDate { get; set; }
	public DateTime? ModificationDate { get; set; }
	[Required]
	[DefaultValue(StoryStatus.Unread)]
	public StoryStatus Status { get; set; }
	[Required]
	[MaxLength(500)]
	public string Title { get; set; } = string.Empty;
	public ICollection<StoryParagraph> Paragraphs { get; set; }
    public string UserId { get; set; }
	public ApplicationUser User { get; set; }
}

public enum StoryStatus
{
	Unread,
	Done
}