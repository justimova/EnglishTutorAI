using DataTransferObjects.Dictionary;

namespace DomainServices.Interfaces;

public interface IDictionaryService
{
	DictionaryDto CreateDictionary(DictionaryDto dictionaryDto);
	DictionaryDto SaveDictionary(DictionaryDto dictionaryDto);
	IEnumerable<DictionaryDto> GetDictionaries(string search = "");
	void DeleteDictionary(int id);
}
