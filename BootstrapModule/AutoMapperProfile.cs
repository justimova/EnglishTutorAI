using AutoMapper;
using DataTransferObjects.Chat;
using DataTransferObjects.Writing;
using OpenAiChat = OpenAI_API.Chat;
using DbModels;
using DataTransferObjects.Reading;
using DataTransferObjects.Dictionary;
using DataTransferObjects.Grammar;
using DataTransferObjects;

namespace BootstrapModule;

internal class AutoMapperProfile : Profile
{
	public AutoMapperProfile() {
		CreateMap<Essay, EssayDto>().ReverseMap();
		CreateMap<OpenAiChat.ChatMessage, AiMessageDto>()
			.ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()));
		//.ForSourceMember(src => src.Images, opt => opt.Ignore());
		CreateMap<AiMessageDto, AiMessage>().ReverseMap();
		CreateMap<Story, StoryDto>().ReverseMap();
		CreateMap<StoryParagraph, StoryParagraphDto>().ReverseMap();
		CreateMap<Dictionary, DictionaryDto>().ReverseMap();
		CreateMap<GrammarTopic, GrammarTopicDto>().ReverseMap();
		CreateMap<LanguageLevel, LanguageLevelDto>().ReverseMap();
	}

}
