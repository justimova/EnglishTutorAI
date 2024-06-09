using DataTransferObjects;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class GrammarTopicController : ControllerBase
{
	private readonly IGrammarTopicService _grammarTopicService;

	public GrammarTopicController(IGrammarTopicService grammarTopicService) {
		_grammarTopicService = grammarTopicService;
	}

    [HttpGet]
	public ActionResult<IEnumerable<GrammarTopicDto>> Get() {
		IEnumerable<GrammarTopicDto> grammarTopicDtos = _grammarTopicService.GetAll();
		return Ok(grammarTopicDtos);
	}
}
