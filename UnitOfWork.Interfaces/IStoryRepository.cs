using DbModels;

namespace UnitOfWork.Interfaces;

public interface IStoryRepository : IRepository<Story>
{
	Story? GetStoryWithParagraphs(int storyId);
	Story? GetStory(int storyId);
	IEnumerable<Story> GetStories(string userId);
}
