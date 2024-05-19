using UnitOfWork.Interfaces;

namespace DomainServices;

public abstract class UnitOfWorkService
{
	protected IUnitOfWork UnitOfWork;

	protected UnitOfWorkService(IUnitOfWork unitOfWork) {
		ArgumentNullException.ThrowIfNull(unitOfWork);
		UnitOfWork = unitOfWork;
	}
}
