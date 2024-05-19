using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class Author
{
	[Key]
	public int AuthorId { get; set; }
	[Required]
	[MaxLength(500)]
	public string AuthorName { get; set; } = string.Empty;
}
