using AutoMapper;
using DataTransferObjects;
using DbModels;
using DomainServices.Interfaces;
using InfrastructureService.Interfaces;
using UnitOfWork.Interfaces;

namespace DomainServices;

public class DictionaryService : UnitOfWorkService, IDictionaryService
{
	private readonly IRepository<Dictionary> _dictionaryRepository;
	private readonly IMapper _mapper;
	private readonly IUserService _userService;

	public DictionaryService(IUnitOfWork unitOfWork, IRepository<Dictionary> dictionaryRepository, IMapper mapper,
			IUserService userService)
			: base(unitOfWork) {
		_dictionaryRepository = dictionaryRepository;
		_mapper = mapper;
		_userService = userService;
	}

	public DictionaryDto CreateDictionary(DictionaryDto dictionaryDto) {
		var currentUser = _userService.GetCurrentUser();
		var dictionary = _mapper.Map<Dictionary>(dictionaryDto);
		dictionary.UserId = currentUser.Id;
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
		var currentUser = _userService.GetCurrentUser();
		search = search.Trim();
		var dictionaries = _dictionaryRepository.GetAll().Where(dict => dict.UserId == currentUser.Id);
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
