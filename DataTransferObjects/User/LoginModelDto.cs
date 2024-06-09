namespace DataTransferObjects.User;

public class LoginModelDto
{
	public required string Password { get; set; }
	public required string Email { get; set; }
}
