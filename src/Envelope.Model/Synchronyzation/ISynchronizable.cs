namespace Envelope.Model.Synchronyzation;

public interface ISynchronizable
{
	Guid SyncToken { get; set; }

	List<string>? GetIgnoredSynchronizationProperties();
}
