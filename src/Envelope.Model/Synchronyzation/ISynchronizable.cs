namespace Envelope.Model.Synchronyzation;

#if NET6_0_OR_GREATER
[Envelope.Serializer.JsonPolymorphicConverter]
#endif
public interface ISynchronizable
{
	Guid SyncToken { get; set; }

	List<string>? GetIgnoredSynchronizationProperties();
}
