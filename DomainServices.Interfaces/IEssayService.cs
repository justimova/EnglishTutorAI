using DataTransferObjects;

namespace DomainServices.Interfaces;

public interface IEssayService
{
	EssayDto CreateEssay(EssayDto essayDto);
	void DeleteEssay(int essayId);
	IEnumerable<EssayDto> GetEssays();
	EssayDto SaveEssay(int essayId, string translatedText);
	EssayDto GetLastDraftEssay();
	int GetDoneEssayCount();
}
