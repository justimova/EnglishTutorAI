using System.ComponentModel.DataAnnotations;

namespace EnglishTutorAI.Model
{
	public class User
	{
		public int Id { get; set; }
		[MaxLength(250)]
		public string? Name { get; set; }
		[MaxLength(250)]
		public string Email { get; set; } = null!;
		[MaxLength(250)]
		public string Password { get; set; } = null!;
	}
}
