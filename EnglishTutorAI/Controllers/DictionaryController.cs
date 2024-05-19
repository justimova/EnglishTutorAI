using DataTransferObjects.Dictionary;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnglishTutorAI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DictionaryController : ControllerBase
	{
		private readonly IDictionaryService _dictionaryService;

		public DictionaryController(IDictionaryService dictionaryService) {
			_dictionaryService = dictionaryService;
		}

		// GET: api/<DictionaryController>/searchDictionaries/search
		[HttpGet]
		[Route("searchDictionaries/{search}")]
		public ActionResult<IEnumerable<DictionaryDto>> SearchDictionaries(string search) {
			IEnumerable<DictionaryDto> dictionaryDtos = _dictionaryService.GetDictionaries(search);
			return Ok(dictionaryDtos);
		}
		
		// GET: api/<DictionaryController>/getAll/search
		[HttpGet]
		public ActionResult<IEnumerable<DictionaryDto>> Get() {
			IEnumerable<DictionaryDto> dictionarieDtos = _dictionaryService.GetDictionaries();
			return Ok(dictionarieDtos);
		}

		//// GET api/<DictionaryController>/5
		//[HttpGet("{id}")]
		//public string Get(int id) {
		//	return "value";
		//}

		// POST api/<DictionaryController>
		[HttpPost]
		public ActionResult<DictionaryDto> Post([FromBody] DictionaryDto dictionaryDto) {
			dictionaryDto = _dictionaryService.CreateDictionary(dictionaryDto);
			return Ok(dictionaryDto);
		}

		// PUT api/<DictionaryController>
		[HttpPut]
		public ActionResult<DictionaryDto> Put([FromBody] DictionaryDto dictionaryDto) {
			dictionaryDto = _dictionaryService.SaveDictionary(dictionaryDto);
			return Ok(dictionaryDto);
		}

		// DELETE api/<DictionaryController>/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id) {
			_dictionaryService.DeleteDictionary(id);
			return Ok();
		}
	}
}
