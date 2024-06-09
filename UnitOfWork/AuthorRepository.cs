using DbModels;
using Microsoft.Extensions.Caching.Memory;
using UnitOfWork.Interfaces;

namespace UnitOfWork;

public class AuthorRepository : Repository<Author>
{
	private readonly IMemoryCache _cache;
	private const string CacheKey = "AuthorsCache";

	public AuthorRepository(IUnitOfWork unitOfWork, IMemoryCache cache) : base(unitOfWork) {
		_cache = cache;
	}

	public override IQueryable<Author> GetAll() {
		IQueryable<Author> authors = _cache?.Get<IQueryable<Author>>(CacheKey);
		if (authors == null || !authors.Any()) {
			authors = base.GetAll();
			if (authors != null && authors.Any()) {
				_cache?.Set(CacheKey, authors);
			}
		}
		return authors;
	}
}
