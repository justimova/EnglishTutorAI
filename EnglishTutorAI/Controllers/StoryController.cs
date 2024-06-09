using DataTransferObjects.Reading;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class StoryController : ControllerBase
{
	private readonly IStoryService _storyService;

	public StoryController(IStoryService storyService) {
		_storyService = storyService;
	}

    // GET: api/<StoryController>
    [HttpGet]
	public ActionResult<IEnumerable<StoryDto>> Get() {
		var storyDtos = _storyService.GetStories();
		return Ok(storyDtos);
	}

	//// GET api/<StoryController>/5
	//[HttpGet("{id}")]
	//public string Get(int id) {
	//	return "value";
	//}

	[HttpGet]
	[Route("getLastUnreadStory")]
	public ActionResult<StoryDto?> GetLastUnreadStory() {
		StoryDto storyDto = _storyService.GetLastUnreadStory();
		return Ok(storyDto);
	}

	[HttpGet]
	[Route("getDoneStoryCount")]
	public ActionResult<int> GetDoneStoryCount() {
		int count = _storyService.GetDoneStoryCount();
		return Ok(count);
	}

	// POST api/<StoryController>
	[HttpPost]
	public ActionResult<StoryDto> Post([FromBody] StoryDto storyDto) {
		storyDto = _storyService.CreateStory(storyDto);
		return Ok(storyDto);
	}

	// PUT api/<StoryController>/5
	[HttpPut("{id}")]
	public ActionResult<StoryDto> Put(int id, [FromBody] int storyStatus) {
		var storyDto = _storyService.SetStoryStatus(id, storyStatus);
		return Ok(storyDto);
	}

	// DELETE api/<StoryController>/5
	[HttpDelete("{id}")]
	public ActionResult Delete(int id) {
		_storyService.DeleteStory(id);
		return Ok();
	}
}
