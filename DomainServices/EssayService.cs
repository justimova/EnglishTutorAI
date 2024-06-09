using AiServices;
using AutoMapper;
using DomainServices.Interfaces;
using UnitOfWork.Interfaces;
using DbModels;
using InfrastructureService.Interfaces;
using DataTransferObjects;

namespace DomainServices;

public class EssayService : UnitOfWorkService, IEssayService
{
	private readonly IMapper _mapper;
	private readonly IEssayRepository _essayRepository;
	private readonly IAiService _aiService;
	private readonly IUserService _userService;
	private readonly ILanguageLevelService _languageLevelService;

	public EssayService(IUnitOfWork unitOfWork,
			IMapper mapper,
			IEssayRepository essayRepository,
			IAiService aiService,
			IUserService userService,
			ILanguageLevelService languageLevelService) : base(unitOfWork) {
		_mapper = mapper;
		_essayRepository = essayRepository;
		_aiService = aiService;
		_userService = userService;
		_languageLevelService = languageLevelService;
	}

	public EssayDto GetLastDraftEssay() {
		var currentUser = _userService.GetCurrentUser();
		var essays = _essayRepository.GetAll()
			.Where(e => e.UserId == currentUser.Id)
			.OrderBy(essay => essay.Status)
			.ThenByDescending(essay => essay.ModificationDate);
		var essay = essays.FirstOrDefault(essay => essay.Status == (int)EssayStatus.Draft);
		return _mapper.Map<EssayDto>(essay);
	}

	public EssayDto CreateEssay(EssayDto essayDto) {
		var currentUser = _userService.GetCurrentUser();
		var languageLevel = _languageLevelService.GetLanguageLevelById(currentUser.LanguageLevelId);
		IList<AiMessageDto> aiMessageDtos = _aiService.CreateTextForWriting(languageLevel.Code,
				out string title, out string text)
			?? throw new Exception("Creation failed");
		essayDto.Title = title;
		essayDto.SourceText = text;
		var now = DateTime.Now;
		essayDto.CreationDate = now;
		essayDto.ModificationDate = now;
		Essay? essay = _mapper.Map<Essay>(essayDto);
		essay.UserId = currentUser.Id;
		essay.AiMessages = aiMessageDtos.Select(x => _mapper.Map<AiMessage>(x)).ToList();
		_essayRepository.Add(essay);
		UnitOfWork.SaveChanges();
		essayDto = _mapper.Map<EssayDto>(essay);
		return essayDto;
	}

	public EssayDto SaveEssay(int essayId, string translatedText) {
		Essay? essay = _essayRepository.GetEssayWithAiMessages(essayId)
			?? throw new Exception("Essay doesn't exist");
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
		var currentUser = _userService.GetCurrentUser();
		IOrderedQueryable<Essay> essays = _essayRepository.GetAll()
			.Where(e => e.UserId == currentUser.Id)
			.OrderBy(essay => essay.Status)
			.ThenByDescending(essay => essay.ModificationDate);
		return essays.Select(essay => _mapper.Map<EssayDto>(essay)).ToList();
	}

	public void DeleteEssay(int essayId) {
		var essay = _essayRepository.GetFirstOrDefault(x => x.EssayId == essayId) 
			?? throw new Exception("Deletion failed");
		_essayRepository.Delete(essay);
		UnitOfWork.SaveChanges();
	}

	public int GetDoneEssayCount() {
		var currentUser = _userService.GetCurrentUser();
		var essays = _essayRepository.GetAll()
			.Where(s => s.UserId == currentUser.Id && s.Status == EssayStatus.Done);
		return essays.Count();
	}
}
