namespace DataTransferObjects.User;

public class RegistrationModelDto
{
	public required string Email { get; set; }
	public required string Password { get; set; }

	public required string Name { get; set; }
	public required LanguageLevelDto LanguageLevel { get; set; }
}
