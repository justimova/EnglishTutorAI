using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DbModels;

public class ApplicationUser : IdentityUser
{
	//[Key]
	//public override string Id { get; set; } = default!;
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
	// public LanguageLevel LanguageLevel { get; set; }
}
