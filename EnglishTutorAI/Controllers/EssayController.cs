using DataTransferObjects.Writing;
using DomainServices;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class EssayController : ControllerBase
{
	private readonly IEssayService _essayService;

	public EssayController(IEssayService essayService) {
		_essayService = essayService;
	}

    // GET: api/<EssayController>
    [HttpGet]
	public ActionResult<IEnumerable<EssayDto>> Get() {
		var essayDtos = _essayService.GetEssays();
		return Ok(essayDtos);
	}

	[HttpGet]
	[Route("getDoneEssayCount")]
	public ActionResult<int> GetDoneEssayCount() {
		int count = _essayService.GetDoneEssayCount();
		return Ok(count);
	}

	//// GET api/<EssayController>/5
	//[HttpGet("{id}")]
	//public string Get(int id) {
	//	return "value";
	//}

	[HttpGet]
	[Route("getLastDraft")]
	public ActionResult<EssayDto?> GetLastDraft() {
		EssayDto essay = _essayService.GetLastDraftEssay();
		return Ok(essay);
	}

	// POST api/<EssayController>
	[HttpPost]
	public ActionResult<EssayDto> Post([FromBody] EssayDto essayDto) {
		essayDto = _essayService.CreateEssay(essayDto);
		return Ok(essayDto);
	}

	// PUT api/<EssayController>/5
	[HttpPut("{id}")]
	public ActionResult<EssayDto> Put(int id, [FromBody] string translatedText) {
		return Ok(_essayService.SaveEssay(id, translatedText));
	}

	// DELETE api/<EssayController>/5
	[HttpDelete("{id}")]
	public ActionResult Delete(int id) {
		_essayService.DeleteEssay(id);
		return Ok();
	}
}
