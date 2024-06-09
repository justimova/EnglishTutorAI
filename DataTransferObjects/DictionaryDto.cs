namespace DataTransferObjects;

public class DictionaryDto
{
    public int DictionaryId { get; set; }
    public string Text { get; set; } = string.Empty;
    public string TranslatedText { get; set; } = string.Empty;
    public string Transcript { get; set; } = string.Empty;
    public string Examples { get; set; } = string.Empty;
}
