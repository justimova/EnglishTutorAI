using DbModels;

namespace UnitOfWork.Interfaces;

public interface IEssayRepository : IRepository<Essay>
{
	Essay? GetEssayWithAiMessages(int essayId);
}
