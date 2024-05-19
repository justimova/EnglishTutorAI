using System.ComponentModel.DataAnnotations;

namespace DbModels;

public class AiMessage
{

	[Key]
	public int AiMessageId { get; set; }
	[Required]
	public string TextContent { get; set; }
	[Required]
	public string Role { get; set; }
	[Required]
	public int Order { get; set; }
	[Required]
	public int EssayId { get; set; }
	public Essay Essay { get; set; }

}
