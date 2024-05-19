using AiServices;
using AutoMapper;
using DataTransferObjects.Grammar;
using DbModels;
using DomainServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Interfaces;

namespace DomainServices;

public class GrammarTopicService : UnitOfWorkService, IGrammarTopicService
{
	private readonly IRepository<GrammarTopic> _grammarTopicRepository;
	private readonly IAiService _aiService;
	private readonly IMapper _mapper;

	public GrammarTopicService(IUnitOfWork unitOfWork, IRepository<GrammarTopic> grammarTopicRepository,
			IAiService aiService,
			IMapper mapper)
			: base(unitOfWork) {
		_grammarTopicRepository = grammarTopicRepository;
		_aiService = aiService;
		_mapper = mapper;
	}

	public IEnumerable<GrammarTopicDto> GetAll() {
		return _grammarTopicRepository.GetAll()
			.Where(topic => !string.IsNullOrEmpty(topic.Explanation))
			.OrderBy(topic => topic.Order)
			.Select(topic => _mapper.Map<GrammarTopicDto>(topic)).ToList();
	}

	public async Task UpdateGrammarTopicsIfNeededAsync(CancellationToken stoppingToken) {
		var topicsWithoutExplanation = _grammarTopicRepository.GetAll()
			.Include(e => e.LanguageLevel)
			.Where(topic => string.IsNullOrEmpty(topic.Explanation))
			.ToList();
		if (topicsWithoutExplanation.Any()) {
			topicsWithoutExplanation.ForEach(topic => {
				topic.Explanation = _aiService.CreateExplanationForGrammarTopicAsync(topic.Text, topic.Description,
					topic.LanguageLevel.Code);
				
			});
			
			await UnitOfWork.SaveChangesAsync();
		}
	}

	
}
