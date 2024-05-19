namespace DataTransferObjects.Chat;

public class AiMessageDto
{
    public int AiMessageId { get; set; }
    public string Name { get; set; }
    public string TextContent { get; set; }
    public string Role { get; set; }
    public int Order { get; set; }
}
