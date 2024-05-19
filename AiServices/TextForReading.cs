using System.Text.Json.Serialization;

namespace AiServices;

internal class TextForReading
{
	[JsonPropertyName("title")]
	public string Title { get; set; }
	[JsonPropertyName("text")]
	public IList<string> Text { get; set; }
	[JsonPropertyName("translatedText")]
	public IList<string> TranslatedText { get; set; }
}
