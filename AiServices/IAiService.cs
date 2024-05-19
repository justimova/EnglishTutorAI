using DataTransferObjects.Chat;

namespace AiServices;

public interface IAiService
{
	string CreateExplanationForGrammarTopicAsync(string topic, string description, string langLevel);
	void CreateTextForReading(string langLevel, string? authorName, out string title, 
		out IList<(string Text, string TranslatedText)> paragraphs);
	IList<AiMessageDto> CreateTextForWriting(string langLevel, out string title, out string text);
	IList<AiMessageDto> GetRecommendationForWriting(string translatedText,
		IList<AiMessageDto> chatHistory, out string recommendation);
}
