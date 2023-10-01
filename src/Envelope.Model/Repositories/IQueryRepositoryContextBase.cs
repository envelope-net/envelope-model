namespace Envelope.Model.Repositories;

public partial interface IQueryRepositoryContextBase
{
	string? ConnectionId { get; }

	void SetConnectionId(string connectionId);
}
