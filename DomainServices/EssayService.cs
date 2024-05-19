using AiServices;
using AutoMapper;
using DataTransferObjects.Chat;
using DataTransferObjects.Writing;
using DomainServices.Interfaces;
using UnitOfWork.Interfaces;
using DbModels;
using System.Collections.Generic;

namespace DomainServices;

public class EssayService : UnitOfWorkService, IEssayService
{
	private readonly IMapper _mapper;
	private readonly IEssayRepository _essayRepository;
	private readonly IAiService _aiService;

	public EssayService(IUnitOfWork unitOfWork,
			IMapper mapper,
			IEssayRepository essayRepository,
			IAiService aiService) : base(unitOfWork) {
		_mapper = mapper;
		_essayRepository = essayRepository;
		_aiService = aiService;
	}

	public EssayDto GetLastDraftEssay() {
		var essays = _essayRepository.GetAll()
			.OrderBy(essay => essay.Status)
			.ThenByDescending(essay => essay.ModificationDate);
		var essay = essays.FirstOrDefault(essay => essay.Status == (int)EssayStatus.Draft);
		return _mapper.Map<EssayDto>(essay);
	}

	public EssayDto CreateEssay(EssayDto essayDto) {
		IList<AiMessageDto> aiMessageDtos = _aiService.CreateTextForWriting("A2", out string title, out string text)
			?? throw new Exception("Something wrong");
		essayDto.Title = title;
		essayDto.SourceText = text;
		var now = DateTime.Now;
		essayDto.CreationDate = now;
		essayDto.ModificationDate = now;
		Essay? essay = _mapper.Map<Essay>(essayDto);
		essay.AiMessages = aiMessageDtos.Select(x => _mapper.Map<AiMessage>(x)).ToList();
		_essayRepository.Add(essay);
		UnitOfWork.SaveChanges();
		essayDto = _mapper.Map<EssayDto>(essay);
		return essayDto;
	}

	public EssayDto SaveEssay(int essayId, string translatedText) {
		Essay? essay = _essayRepository.GetEssayWithAiMessages(essayId);
		if (essay == null) {
			throw new Exception("Essay doesn't exist");
		}
		essay.TranslatedText = translatedText;
		IList<AiMessageDto> chatMessageDtos = essay.AiMessages.OrderBy(x => x.Order).Select(aiMessage =>
			_mapper.Map<AiMessageDto>(aiMessage)).ToList();
		IList<AiMessageDto> newChatMessageDtos = _aiService.GetRecommendationForWriting(translatedText, chatMessageDtos,
			out string recommendation);
		essay.Recommendation = recommendation;
		essay.Status = EssayStatus.Done;
		foreach(var messageDto in newChatMessageDtos) {
			essay.AiMessages.Add(_mapper.Map<AiMessage>(messageDto));
		}
		var now = DateTime.Now;
		essay.ModificationDate = now;
		UnitOfWork.SaveChanges();
		return _mapper.Map<EssayDto>(essay);
	}

	public IEnumerable<EssayDto> GetEssays() {
		IOrderedQueryable<Essay> essays = _essayRepository.GetAll()
			.OrderBy(essay => essay.Status)
			.ThenByDescending(essay => essay.ModificationDate);
		return essays.Select(essay => _mapper.Map<EssayDto>(essay)).ToList();
	}

	public void DeleteEssay(int essayId) {
		var essay = _essayRepository.GetFirstOrDefault(x => x.EssayId == essayId);
		if (essay == null) {
			throw new Exception("Something wrong");
		}
		_essayRepository.Delete(essay);
		UnitOfWork.SaveChanges();
	}
}
