using AutoMapper;
using DataTransferObjects.Dictionary;
using DbModels;
using DomainServices.Interfaces;
using UnitOfWork.Interfaces;

namespace DomainServices;

public class DictionaryService : UnitOfWorkService, IDictionaryService
{
	private readonly IRepository<Dictionary> _dictionaryRepository;
	private readonly IMapper _mapper;

	public DictionaryService(IUnitOfWork unitOfWork, IRepository<Dictionary> dictionaryRepository, IMapper mapper)
			: base(unitOfWork) {
		_dictionaryRepository = dictionaryRepository;
		_mapper = mapper;
	}

	public DictionaryDto CreateDictionary(DictionaryDto dictionaryDto) {
		var dictionary = _mapper.Map<Dictionary>(dictionaryDto);
		_dictionaryRepository.AddEntity(dictionary);
		UnitOfWork.SaveChanges();
		return _mapper.Map<DictionaryDto>(dictionary);
	}

	public DictionaryDto SaveDictionary(DictionaryDto dictionaryDto) {
		var dictionary = _dictionaryRepository.GetFirstOrDefault(dict => dict.DictionaryId == dictionaryDto.DictionaryId);
		if (dictionary == null) {
			throw new Exception("Something wrong");
		}
		dictionary.Text = dictionaryDto.Text;
		dictionary.TranslatedText = dictionaryDto.TranslatedText;
		dictionary.Examples = dictionaryDto.Examples;
		dictionary.Transcript = dictionaryDto.Transcript;
		UnitOfWork.SaveChanges();
		return _mapper.Map<DictionaryDto>(dictionary);
	}

	public IEnumerable<DictionaryDto> GetDictionaries(string search = "") {
		search = search.Trim();
		var dictionaries = _dictionaryRepository.GetAll();
		if (!string.IsNullOrEmpty(search)) {
			dictionaries = dictionaries.Where(dictionary => dictionary.Text.Contains(search));
		}
		return dictionaries.Select(dictionary => _mapper.Map<DictionaryDto>(dictionary));
	}

	public void DeleteDictionary(int dictionaryId) {
		var dictionary = _dictionaryRepository.GetFirstOrDefault(x => x.DictionaryId == dictionaryId);
		if (dictionary == null) {
			throw new Exception("Something wrong");
		}
		_dictionaryRepository.Delete(dictionary);
		UnitOfWork.SaveChanges();
	}
}
