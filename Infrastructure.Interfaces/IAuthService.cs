﻿using DataTransferObjects.User;

namespace Infrastructure.Interfaces;

public interface IAuthService
{
	Task<UserDto> LoginAsync(LoginModelDto model);
}