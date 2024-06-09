using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObjects;

public class UserDto
{
    public required string Id { get; set; }
    public required string UserName { get; set; }
    public string? Email { get; set; }
    [NotMapped]
    public string Token { get; set; } = default!;
    public int LanguageLevelId { get; set; }
    public string FirstName { get; set; }
}
