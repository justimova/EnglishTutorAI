using System.Security;
using DataTransferObjects.User;
using Infrastructure.Interfaces;
using InfrastructureService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnglishTutorAI.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class AuthController : ControllerBase
{
	private readonly IAuthService _authService;
	private readonly IUserService _userService;

	public AuthController(IAuthService authService, IUserService userService) {
		_authService = authService;
		_userService = userService;
	}

	[HttpPost("register")]
	public async Task<IActionResult> Register([FromBody] RegistrationModelDto model) {
		var result = await _userService.CreateUserAsync(model);
		if (result.Succeeded) {
			return Ok();
		}
		return BadRequest(result.Errors);
	}

	[HttpPost("login")]
	public async Task<IActionResult> Login([FromBody] LoginModelDto model) {
		try {
			UserDto userDto = await _authService.LoginAsync(model);
			return Ok(userDto);
		} catch (SecurityException) {
			return Unauthorized(new { message = "Invalid email or password. Please enter correct email and password" });
		}
	}

}
