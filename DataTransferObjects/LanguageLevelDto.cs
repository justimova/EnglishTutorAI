namespace DataTransferObjects;

public class LanguageLevelDto
{
	public int LanguageLevelId { get; set; }
	public string Code { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public int Order { get; set; } = 0;
}
