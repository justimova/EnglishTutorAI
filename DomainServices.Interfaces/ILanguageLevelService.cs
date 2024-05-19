using DataTransferObjects;

namespace DomainServices.Interfaces;

public interface ILanguageLevelService
{
	IEnumerable<LanguageLevelDto> GetLanguageLevels();
}
