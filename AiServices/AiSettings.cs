namespace AiServices;

public class AiSettings
{
	private static readonly int _defaultNumberOfWordsForReadingText = 2000;
	private int _numberOfWordsForReadingText = 0;
	public int NumberOfWordsForReadingText {
		get => _numberOfWordsForReadingText;
		set {
			_numberOfWordsForReadingText = value;
			if (_numberOfWordsForReadingText == 0)
				_numberOfWordsForReadingText = _defaultNumberOfWordsForReadingText;
		}
	}
	public string CreateWritingTextSystemMessage { get; set; } = string.Empty;
	public string CreateWritingTextUserMessage { get; set; } = string.Empty;
    public string GetRecommendationWritingTextSystemMessage { get; set; } = string.Empty;
    public string GetTopicSystemMessage { get; set; } = string.Empty;
    public string GetTopicUserMessage { get; set; } = string.Empty;
    public string CreateReadingTextSystemMessage { get; set; } = string.Empty;
    public string CreateReadingTextUserMessage { get; set; } = string.Empty;
    public string CreateGrammarTopicSystemMessage { get; set; } = string.Empty;
     public string CreateGrammarTopicUserMessage { get; set; } = string.Empty;
   public string SecretKey { get; set; } = string.Empty;
}
