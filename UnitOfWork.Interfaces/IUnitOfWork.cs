namespace UnitOfWork.Interfaces;

public interface IUnitOfWork
{
	void SaveChanges();
	Task<int> SaveChangesAsync();
}
