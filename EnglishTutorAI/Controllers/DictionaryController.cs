using DataTransferObjects;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class DictionaryController : ControllerBase
{
	private readonly IDictionaryService _dictionaryService;

	public DictionaryController(IDictionaryService dictionaryService) {
		_dictionaryService = dictionaryService;
	}

	[HttpGet]
	[Route("searchDictionaries/{search}")]
	public ActionResult<IEnumerable<DictionaryDto>> SearchDictionaries(string search) {
		IEnumerable<DictionaryDto> dictionaryDtos = _dictionaryService.GetDictionaries(search);
		return Ok(dictionaryDtos);
	}
	
	[HttpGet]
	public ActionResult<IEnumerable<DictionaryDto>> Get() {
		IEnumerable<DictionaryDto> dictionarieDtos = _dictionaryService.GetDictionaries();
		return Ok(dictionarieDtos);
	}

	[HttpPost]
	public ActionResult<DictionaryDto> Post([FromBody] DictionaryDto dictionaryDto) {
		dictionaryDto = _dictionaryService.CreateDictionary(dictionaryDto);
		return Ok(dictionaryDto);
	}

	[HttpPut]
	public ActionResult<DictionaryDto> Put([FromBody] DictionaryDto dictionaryDto) {
		dictionaryDto = _dictionaryService.SaveDictionary(dictionaryDto);
		return Ok(dictionaryDto);
	}

	[HttpDelete("{id}")]
	public ActionResult Delete(int id) {
		_dictionaryService.DeleteDictionary(id);
		return Ok();
	}
}
