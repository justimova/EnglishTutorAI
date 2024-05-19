using DataTransferObjects;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageLevelController : ControllerBase
{
	private readonly ILanguageLevelService _languageLevelService;

	public LanguageLevelController(ILanguageLevelService languageLevelService) {
		_languageLevelService = languageLevelService;
	}

    // GET: api/<LangLevelController>
    [HttpGet]
	public ActionResult<IEnumerable<LanguageLevelDto>> Get() {
		IEnumerable<LanguageLevelDto> levels = _languageLevelService.GetLanguageLevels();
		return Ok(levels);
	}

	//// GET api/<LangLevelController>/5
	//[HttpGet("{id}")]
	//public string Get(int id) {
	//	return "value";
	//}

	//// POST api/<LangLevelController>
	//[HttpPost]
	//public void Post([FromBody] string value) {
	//}

	//// PUT api/<LangLevelController>/5
	//[HttpPut("{id}")]
	//public void Put(int id, [FromBody] string value) {
	//}

	//// DELETE api/<LangLevelController>/5
	//[HttpDelete("{id}")]
	//public void Delete(int id) {
	//}
}
