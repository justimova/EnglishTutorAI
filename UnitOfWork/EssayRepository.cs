using DbModels;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Interfaces;

namespace UnitOfWork;

public class EssayRepository : Repository<Essay>, IEssayRepository
{
	public EssayRepository(IUnitOfWork unitOfWork) : base(unitOfWork) {
	}

	public Essay? GetEssayWithAiMessages(int essayId) {
		return Context.Essays
			.Include(e => e.AiMessages)
			.FirstOrDefault(e => e.EssayId == essayId);
	}
}
