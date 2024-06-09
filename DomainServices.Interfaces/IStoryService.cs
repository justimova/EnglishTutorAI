using DataTransferObjects.Reading;

namespace DomainServices.Interfaces;

public interface IStoryService
{
	IEnumerable<StoryDto> GetStories();
	StoryDto CreateStory(StoryDto storyDto);
	StoryDto? GetLastUnreadStory();
	StoryDto SetStoryStatus(int storyId, int storyStatus);
	void DeleteStory(int storyId);
	int GetDoneStoryCount();
}
