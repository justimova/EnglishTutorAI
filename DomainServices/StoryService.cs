using AiServices;
using AutoMapper;
using DataTransferObjects;
using DbModels;
using DomainServices.Interfaces;
using InfrastructureService.Interfaces;
using UnitOfWork.Interfaces;

namespace DomainServices;

public class StoryService : UnitOfWorkService, IStoryService
{
	private readonly IAiService _aiService;
	private readonly IStoryRepository _storyRepository;
	private readonly IRepository<Author> _authorRepository;
	private readonly IMapper _mapper;
	private readonly IUserService _userService;
	private readonly ILanguageLevelService _languageLevelService;

	public StoryService(IUnitOfWork unitOfWork,
			IAiService aiService,
			IStoryRepository storyRepository,
			IRepository<Author> authorRepository,
			IMapper mapper,
			IUserService userService,
			ILanguageLevelService languageLevelService) : base(unitOfWork) {
		_aiService = aiService;
		_storyRepository = storyRepository;
		_authorRepository = authorRepository;
		_mapper = mapper;
		_userService = userService;
		_languageLevelService = languageLevelService;
	}

	private string? GetRandomAuthor(List<Author> authors) {
		Random rnd = new();
		int index = rnd.Next(authors.Count);
		Author randomAuthor = authors[index];
		return randomAuthor?.AuthorName;
	}

    public IEnumerable<StoryDto> GetStories() {
		var currentUser = _userService.GetCurrentUser();
		IEnumerable<Story> stories = _storyRepository.GetStories(currentUser.Id);
		IEnumerable<StoryDto> storyDtos = stories.Select(story => _mapper.Map<StoryDto>(story));
		return storyDtos;
	}

	public StoryDto CreateStory(StoryDto storyDto) {
		var currentUser = _userService.GetCurrentUser();
		var languageLevel = _languageLevelService.GetLanguageLevelById(currentUser.LanguageLevelId);
		List<Author> authors = [.. _authorRepository.GetAll()];
		var authorName = GetRandomAuthor(authors);
		_aiService.CreateTextForReading(languageLevel.Code, authorName, out string title,
			out IList<(string Text, string TranslatedText)> paragraphs);
		Story story = _mapper.Map<Story>(storyDto);
		story.UserId = currentUser.Id;
		story.Title = title;
		story.Status = StoryStatus.Unread;
		var now = DateTime.Now;
		story.CreationDate = now;
		story.ModificationDate = now;
		int order = 0;
		story.Paragraphs = paragraphs.Select(par => new StoryParagraph {
			Text = par.Text,
			TranslatedText = par.TranslatedText,
			Order = order++
		}).ToList();
		_storyRepository.Add(story);
		UnitOfWork.SaveChanges();
		storyDto.Title = title;
		return _mapper.Map<StoryDto>(story);
	}

	public StoryDto? GetLastUnreadStory() {
		var currentUser = _userService.GetCurrentUser();
		var essays = _storyRepository.GetAll()
			.Where(s => s.UserId == currentUser.Id)
			.OrderBy(story => story.Status)
			.ThenByDescending(story => story.ModificationDate);
		var story = essays.FirstOrDefault(essay => essay.Status == (int)StoryStatus.Unread);
		if (story == null) {
			return null;
		}
		story = _storyRepository.GetStoryWithParagraphs(story.StoryId);
		return _mapper.Map<StoryDto>(story);
	}

	public int GetDoneStoryCount() {
		var currentUser = _userService.GetCurrentUser();
		var essays = _storyRepository.GetAll()
			.Where(s => s.UserId == currentUser.Id && s.Status == StoryStatus.Done);
		return essays.Count();
	}

	public StoryDto SetStoryStatus(int storyId, int storyStatus) {
		StoryStatus status = (StoryStatus)storyStatus;
		var story = _storyRepository.GetStory(storyId) ?? throw new Exception("Something wrong");
		story.Status = status;
		var now = DateTime.Now;
		story.ModificationDate = now;
		UnitOfWork.SaveChanges();
		return _mapper.Map<StoryDto>(story);
	}

	public void DeleteStory(int storyId) {
		var essay = _storyRepository.GetFirstOrDefault(x => x.StoryId == storyId);
		_storyRepository.Delete(essay);
		UnitOfWork.SaveChanges();
	}
}
