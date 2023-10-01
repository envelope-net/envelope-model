namespace Envelope.Model.Repositories;

public partial interface IEntityRepositoryBase
{
}

public interface IEntityRepositoryBase<T> : IEntityRepositoryBase
{
	Task<IQueryable<T>> AsQueryableAsync(CancellationToken cancellationToken = default);

	Task<IQueryable<T>> AsReadOnlyQueryableAsync(CancellationToken cancellationToken = default);

	Task AddAsync(T entity, CancellationToken cancellationToken = default);

	Task RemoveAsync(T entity, CancellationToken cancellationToken = default);
}
