using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Interfaces;

namespace UnitOfWork;

public class Repository
{
	protected ApplicationContext Context;

	public Repository(IUnitOfWork unitOfWork) {
		Context = unitOfWork as ApplicationContext;
		if (Context == null) {
			throw new InvalidOperationException("UnitOfWork of the type EnglishTrainingDbContext should" +
				" be used while a entity framework data access are used.");
		}
	}
}

public class Repository<T> : Repository, IRepository<T> where T : class
{
	public Repository(IUnitOfWork unitOfWork)
		: base(unitOfWork) {
	}

	public virtual T GetFirstOrDefault(Expression<Func<T, bool>> expression) {
		return GetAll().FirstOrDefault(expression);
	}

	protected virtual IQueryable<T> GetMainAll() {
		return Context.Set<T>();
	}

	public virtual IQueryable<T> GetAll() {
		return GetMainAll();
	}

	public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate) {
		return GetAll().Where(predicate);
	}

	public virtual void Add(T entity) {
		Context.Set<T>().Add(entity);
	}

	public virtual async Task AddAsync(T entity) {
		await Context.Set<T>().AddAsync(entity);
	}

	public void AddRange(IEnumerable<T> entitys) {
		Context.Set<T>().AddRange(entitys);
	}

	public async Task AddRangeAsync(IEnumerable<T> entitys) {
		await Context.Set<T>().AddRangeAsync(entitys);
	}

	public virtual void Delete(T entity) {
		Context.Set<T>().Remove(entity);
	}

	public T GetSingle(Expression<Func<T, bool>> expression) {
		return GetAll().FirstOrDefault(expression);
	}

	public void AddEntity<TEntity>(TEntity entity) where TEntity : class {
		Context.Entry(entity).State = EntityState.Added;
	}
}
