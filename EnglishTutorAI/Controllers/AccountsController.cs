using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[Route("[controller]")]
[ApiController]
[Authorize]
public class AccountsController : ControllerBase
{
	//private readonly UserManager<User> _userManager;
	//private readonly IMapper _mapper;

	//public AccountsController(UserManager<User> userManager, IMapper mapper) {
	//	_userManager = userManager;
	//	_mapper = mapper;
	//}

	//[AllowAnonymous]
	//[HttpGet]
	//public IActionResult Get() {
	//	return Ok();
	//}

	//[AllowAnonymous]
	//[HttpPost("Registration")]
	//public async Task<IActionResult> RegisterUserAsync([FromBody] UserForRegistrationDto userForRegistration) {
	//	if (userForRegistration == null || !ModelState.IsValid)
	//		return BadRequest();
	//	var user = _mapper.Map<User>(userForRegistration);
	//	var result = await _userManager.CreateAsync(user, userForRegistration.Password);
	//	if (!result.Succeeded) {
	//		var errors = result.Errors.Select(e => e.Description);
	//		return BadRequest(new RegistrationResponseDto { Errors = errors });
	//	}
	//	return StatusCode((int)HttpStatusCode.Created);
	//}

	//[AllowAnonymous]
	//[HttpGet]
	//public ActionResult Login() {
	//	return StatusCode(200);
	//}

	//public ActionResult Logout() {
	//	throw new NotImplementedException();
	//}
}
