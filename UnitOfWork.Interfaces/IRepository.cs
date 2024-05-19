using System.Linq.Expressions;

namespace UnitOfWork.Interfaces;

public interface IRepository<T> where T : class
{
	T GetFirstOrDefault(Expression<Func<T, bool>> expression);

	IQueryable<T> GetAll();
	IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

	void Add(T entity);
	Task AddAsync(T entity);
	void AddRange(IEnumerable<T> entitys);
	Task AddRangeAsync(IEnumerable<T> entitys);
	void Delete(T entity);

	void AddEntity<TEntity>(TEntity entity) where TEntity : class;

	//T GetById(int id);
	T GetSingle(Expression<Func<T, bool>> expression);
}
