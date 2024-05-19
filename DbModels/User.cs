using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DbModels;

public class User : IdentityUser
{
	[MaxLength(250)]
	public string? FirstName { get; set; }
	[MaxLength(250)]
	public string? LastName { get; set; }
	//[MaxLength(250)]
	//public string Password { get; set; } = null!;
}
