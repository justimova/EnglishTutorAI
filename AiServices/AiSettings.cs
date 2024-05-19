namespace AiServices;

public interface IAiSettings {
	int NumberOfWordsForReadingText { get; set; }

	string CreateWritingTextSystemMessage { get; set; }
    string CreateWritingTextUserMessage { get; set; }
	string GetRecommendationWritingTextSystemMessage { get; set; }
	string GetTopicSystemMessage { get; set; }
	string GetTopicUserMessage { get; set; }
	string CreateReadingTextSystemMessage { get; set; }
	string CreateReadingTextUserMessage { get; set; }
}

public class AiSettings : IAiSettings
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
}
