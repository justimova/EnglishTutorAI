using System.IdentityModel.Tokens.Jwt;
using System.Security;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using DataTransferObjects.User;
using DbModels;
using Infrastructure.Interfaces;
using InfrastructureService.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace InfrastructureService;

public class AuthService : IAuthService
{
	private readonly IUserService _userService;
	private readonly SignInManager<ApplicationUser> _signInManager;
	private readonly IMapper _mapper;
	private readonly AuthSettings _authSettings;

	public AuthService(IUserService userService,
			SignInManager<ApplicationUser> signInManager,
			IOptions<AuthSettings> authSettings,
			IMapper mapper) {
		_userService = userService;
		_signInManager = signInManager;
		_mapper = mapper;
		_authSettings = authSettings.Value;
	}

	private string GenerateJwtToken(UserDto userDto) {
		var claims = new[] {
			new Claim(JwtRegisteredClaimNames.Sub, userDto.UserName),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
			new Claim(ClaimTypes.NameIdentifier, userDto.Id)
		};
		var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authSettings.Key));
		var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
		var token = new JwtSecurityToken(
			issuer: _authSettings.Issuer,
			audience: _authSettings.Audience,
			claims: claims,
			expires: DateTime.Now.AddDays(1),
			signingCredentials: creds
		);
		return new JwtSecurityTokenHandler().WriteToken(token);
	}

	public async Task<UserDto> LoginAsync(LoginModelDto model) {
		SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
		if (result.Succeeded) {
			UserDto currentUserDto = await _userService.FindUserByEmailAsync(model.Email);
			currentUserDto.Token = GenerateJwtToken(currentUserDto);
			return currentUserDto;
		}
		throw new SecurityException("Login error");
	}
}
