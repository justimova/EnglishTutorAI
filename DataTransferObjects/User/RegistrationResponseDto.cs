namespace DataTransferObjects.User;

public class RegistrationResponseDto
{
    public bool IsSuccess { get; set; }
    public IEnumerable<string>? Errors { get; set; }
}
