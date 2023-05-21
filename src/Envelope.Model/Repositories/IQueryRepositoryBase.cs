namespace Envelope.Model.Repositories;

public partial interface IQueryRepositoryBase
{
}

public interface IQueryRepositoryBase<T> : IQueryRepositoryBase
{
	Task<IQueryable<T>> AsQueryableAsync(CancellationToken cancellationToken = default);

	Task<IQueryable<T>> AsReadOnlyQueryableAsync(CancellationToken cancellationToken = default);
}
