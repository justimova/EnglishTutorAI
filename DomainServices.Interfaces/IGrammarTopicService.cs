using DataTransferObjects.Grammar;

namespace DomainServices.Interfaces;

public interface IGrammarTopicService
{
	IEnumerable<GrammarTopicDto> GetAll();
	Task UpdateGrammarTopicsIfNeededAsync(CancellationToken stoppingToken);
}
