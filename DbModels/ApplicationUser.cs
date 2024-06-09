using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DbModels;

public class ApplicationUser : IdentityUser
{
	[MaxLength(250)]
	public string? FirstName { get; set; }
	[MaxLength(250)]
	public string? LastName { get; set; }
	[Required]
	public DateTime CreationDate { get; set; }
	public DateTime? ModificationDate { get; set; }
	[Required]
	[DefaultValue(1)]
	public int LanguageLevelId { get; set; } = 1;
}
