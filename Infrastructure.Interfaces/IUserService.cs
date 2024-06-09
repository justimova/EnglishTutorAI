using DataTransferObjects;
using Microsoft.AspNetCore.Identity;

namespace InfrastructureService.Interfaces;

public interface IUserService
{
	Task<IdentityResult> CreateUserAsync(RegistrationModelDto model);
	Task<UserDto> FindUserByEmailAsync(string email);
	UserDto GetCurrentUser();
	UserDto SaveCurrentUser(UpdateUserModel userDto);
}
