using System.Text.Json.Serialization;

namespace DataTransferObjects.Writing;

internal class TextForWriting
{
	[JsonPropertyName("topic")]
	public string Topic { get; set; }
	[JsonPropertyName("summary")]
	public string Summary { get; set; }
	[JsonPropertyName("text")]
    public string Text { get; set; }
}
