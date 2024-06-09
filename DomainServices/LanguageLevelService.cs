using AutoMapper;
using DataTransferObjects;
using DbModels;
using DomainServices.Interfaces;
using UnitOfWork.Interfaces;

namespace DomainServices;

public class LanguageLevelService : UnitOfWorkService, ILanguageLevelService
{
	private readonly IRepository<LanguageLevel> _languageLevelRepository;
	private readonly IMapper _mapper;

	public LanguageLevelService(IUnitOfWork unitOfWork,
            IRepository<LanguageLevel> languageLevelRepository,
			IMapper mapper) : base(unitOfWork) {
		_languageLevelRepository = languageLevelRepository;
		_mapper = mapper;
	}

	public LanguageLevelDto GetLanguageLevelById(int languageLevelId) {
		var languageLevel = _languageLevelRepository
			.GetAll().FirstOrDefault(l => l.LanguageLevelId == languageLevelId);
			//.FindBy(l => l.LanguageLevelId == languageLevelId);
		return _mapper.Map<LanguageLevelDto>(languageLevel);
	}

	public IEnumerable<LanguageLevelDto> GetLanguageLevels() {
		var languageLevels = _languageLevelRepository
			.GetAll()
			.OrderBy(level => level.Order);
		return languageLevels.Select(level => _mapper.Map<LanguageLevelDto>(level));
	}
}
