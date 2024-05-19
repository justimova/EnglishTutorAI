using DataTransferObjects.Grammar;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GrammarTopicController : ControllerBase
{
	private readonly IGrammarTopicService _grammarTopicService;

	public GrammarTopicController(IGrammarTopicService grammarTopicService) {
		_grammarTopicService = grammarTopicService;
	}

    // GET: api/<GrammarTopicController>
    [HttpGet]
	public ActionResult<IEnumerable<GrammarTopicDto>> Get() {
		IEnumerable<GrammarTopicDto> grammarTopicDtos = _grammarTopicService.GetAll();
		return Ok(grammarTopicDtos);
	}

	// GET api/<GrammarTopicController>/5
	[HttpGet("{id}")]
	public string Get(int id) {
		return "value";
	}

	// POST api/<GrammarTopicController>
	[HttpPost]
	public void Post([FromBody] string value) {
	}

	// PUT api/<GrammarTopicController>/5
	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value) {
	}

	// DELETE api/<GrammarTopicController>/5
	[HttpDelete("{id}")]
	public void Delete(int id) {
	}
}
