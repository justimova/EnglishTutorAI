using System.Security.Claims;
using AutoMapper;
using DataTransferObjects.User;
using DbModels;
using InfrastructureService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace InfrastructureService;

public class UserService : IUserService {
	private readonly UserManager<ApplicationUser> _userManager;
	private readonly IMapper _mapper;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public UserService(UserManager<ApplicationUser> userManager, IMapper mapper, IHttpContextAccessor httpContextAccessor) {
		_userManager = userManager;
		_mapper = mapper;
		_httpContextAccessor = httpContextAccessor;
	}

	public async Task<IdentityResult> CreateUserAsync(RegistrationModelDto model) {
		var languageLevel = _mapper.Map<LanguageLevel>(model.LanguageLevel);
		var user = new ApplicationUser {
			UserName = model.Email,
			Email = model.Email,
			FirstName = model.Name,
			// LanguageLevel = languageLevel,
			LanguageLevelId = languageLevel.LanguageLevelId
		};
		var result = await _userManager.CreateAsync(user, model.Password);
		return result;
	}

	public UserDto SaveCurrentUser(UpdateUserModel updateUserModel) {
		var user = Task.Run(async () => await _userManager.FindByEmailAsync(updateUserModel.Email)).Result
			?? throw new Exception("User is not atuthorized");
		user.FirstName = updateUserModel.FirstName;
		user.LanguageLevelId = updateUserModel.LanguageLevelId;
		_userManager.UpdateAsync(user).GetAwaiter().GetResult();
		return _mapper.Map<UserDto>(user);
	}

	public async Task<UserDto> FindUserByEmailAsync(string email) {
		var user = await _userManager.FindByEmailAsync(email);
		return _mapper.Map<UserDto>(user);
	}

	public UserDto GetCurrentUser() {
		var email = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
		var userDto = Task.Run(async () => await FindUserByEmailAsync(email)).Result;
		return userDto;
	}
}
