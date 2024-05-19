using DbModels;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Interfaces;

namespace UnitOfWork;

public class StoryRepository : Repository<Story>, IStoryRepository
{
	public StoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork) {
	}

	public IEnumerable<Story> GetStories() {
		var stories = Context.Stories
			.Include(e => e.Paragraphs)
			.OrderBy(essay => essay.Status)
			.ThenByDescending(essay => essay.ModificationDate).ToList();
		foreach (var story in stories) {
			story.Paragraphs = story.Paragraphs.OrderBy(p => p.Order).ToList();
		}
		return stories;
	}

	public Story? GetStory(int storyId) {
		return GetFirstOrDefault(story => story.StoryId == storyId);
	}

	public Story? GetStoryWithParagraphs(int storyId) {
		return Context.Stories
			.Include(e => e.Paragraphs)
			.FirstOrDefault(e => e.StoryId == storyId);
	}
}
