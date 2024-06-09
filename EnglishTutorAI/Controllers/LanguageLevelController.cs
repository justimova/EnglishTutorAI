using DataTransferObjects;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class LanguageLevelController : ControllerBase
{
	private readonly ILanguageLevelService _languageLevelService;

	public LanguageLevelController(ILanguageLevelService languageLevelService) {
		_languageLevelService = languageLevelService;
	}

    [HttpGet]
	public ActionResult<IEnumerable<LanguageLevelDto>> Get() {
		IEnumerable<LanguageLevelDto> levels = _languageLevelService.GetLanguageLevels();
		return Ok(levels);
	}
}
