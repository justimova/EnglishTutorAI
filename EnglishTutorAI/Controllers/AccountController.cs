using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using InfrastructureService.Interfaces;
using DataTransferObjects;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class AccountController : ControllerBase
{
	private readonly IUserService _userService;

	public AccountController(IUserService userService) {
		_userService = userService;
	}

	[HttpGet]
	[Route("getCurrentUser")]
	public ActionResult<UserDto> GetCurrentUser() {
		var userDto = _userService.GetCurrentUser();
		return Ok(userDto);
	}

	[HttpPut]
	public ActionResult<UserDto> Put([FromBody] UpdateUserModel updateUserModel) {
		var userDto = _userService.SaveCurrentUser(updateUserModel);
		return Ok(userDto);
	}
}
