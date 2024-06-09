using System.Text.Json;
using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Writing;
using Microsoft.Extensions.Options;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;

namespace AiServices;

public class AiService : IAiService
{
	private readonly string _jsonResponseFormat = "JSON";
	private readonly AiSettings _aiSettings;
	private readonly IMapper _mapper;
	private readonly OpenAIAPI _openAIAPI;

	public AiService(IOptions<AiSettings> aiSettings, IMapper mapper) {
		_aiSettings = aiSettings.Value;
		_mapper = mapper;
		string apiKey = _aiSettings.SecretKey;
		APIAuthentication auth = new(apiKey);
		_openAIAPI = new(auth);
	}

	private Conversation CreateChatConversation(string? responseFormat = null) {
		Conversation chat = _openAIAPI.Chat.CreateConversation();
		chat.Model = Model.GPT4_Turbo;
		chat.RequestParameters.Temperature = 1;
		if (responseFormat != null) {
			chat.RequestParameters.ResponseFormat = responseFormat;
		}
		return chat;
	}

	private IList<AiMessageDto> CreateChatMessageHistory(IList<ChatMessage> chatMessages, int initialOrder = 0) {
		IList<AiMessageDto> chatMessageDtos = new List<AiMessageDto>();
		foreach (ChatMessage msg in chatMessages) {
			var chatMessageDto = _mapper.Map<AiMessageDto>(msg);
			chatMessageDto.Order = initialOrder++;
			chatMessageDtos.Add(chatMessageDto);
		}
		return chatMessageDtos;
	}

	private string GetTopic() {
		Conversation chat = CreateChatConversation();
		chat.AppendSystemMessage(_aiSettings.GetTopicSystemMessage);
		chat.AppendUserInput(_aiSettings.GetTopicUserMessage);
		var topic = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
		return topic;
	}

	public IList<AiMessageDto> CreateTextForWriting(string langLevel, out string topic, out string text) {
		Conversation chat = CreateChatConversation(responseFormat: _jsonResponseFormat);
		chat.AppendSystemMessage(string.Format(_aiSettings.CreateWritingTextSystemMessage, langLevel));
		var subject = GetTopic();
		chat.AppendUserInput(string.Format(_aiSettings.CreateWritingTextSystemMessage, subject));
		string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
		TextForWriting? textForWriting = JsonSerializer.Deserialize<TextForWriting>(response.ReplaceLineEndings(" "))
			?? throw new Exception("Something wrong");
		topic = textForWriting.Topic;
		text = textForWriting.Text;
		return CreateChatMessageHistory(chat.Messages);
	}

	public IList<AiMessageDto> GetRecommendationForWriting(string translatedText,
			IList<AiMessageDto> chatMessageHistory,
			out string recommendation) {
		Conversation chat = CreateChatConversation();
		foreach (AiMessageDto messageDto in chatMessageHistory) {
			chat.AppendMessage(ChatMessageRole.FromString(messageDto.Role), messageDto.TextContent);
		}
		chat.AppendSystemMessage(_aiSettings.GetRecommendationWritingTextSystemMessage);
		chat.AppendUserInput(translatedText);
		recommendation = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
		List<ChatMessage> lastMessages = chat.Messages.Skip(Math.Max(0, chat.Messages.Count - 3)).ToList();
		int order = chatMessageHistory.Max(x => x.Order) + 1;
		return CreateChatMessageHistory(lastMessages, order);
	}

	public void CreateTextForReading(string langLevel, string? authorName, out string title,
			out IList<(string Text, string TranslatedText)> paragraphs) {
		Conversation chat = CreateChatConversation(responseFormat: _jsonResponseFormat);
		chat.AppendSystemMessage(string.Format(_aiSettings.CreateReadingTextSystemMessage,
			_aiSettings.NumberOfWordsForReadingText, langLevel));
		chat.AppendUserInput(string.Format(_aiSettings.CreateReadingTextUserMessage, authorName));
		string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
		TextForReading? textForReading = JsonSerializer.Deserialize<TextForReading>(response)
			?? throw new Exception("Something wrong");
		title = textForReading.Title;
		paragraphs = textForReading.Text.Zip(textForReading.TranslatedText,
			(text, translatedText) => (Text: text, TranslatedText: translatedText)).ToList();
    }

	public string CreateExplanationForGrammarTopicAsync(string topic, string description, string langLevel) {
		Conversation chat = CreateChatConversation();
		chat.AppendSystemMessage(string.Format(_aiSettings.CreateGrammarTopicSystemMessage, langLevel));
		chat.AppendUserInput(string.Format(_aiSettings.CreateGrammarTopicUserMessage, topic, description));
		string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
		return response;
	}
}
