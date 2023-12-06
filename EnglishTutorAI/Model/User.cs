namespace EnglishTutorAI.Model
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = null!;
		public string Password { get; set; } = null!;
	}
}
