namespace Envelope.Model;

#if NET6_0_OR_GREATER
[Envelope.Serializer.JsonPolymorphicConverter]
#endif
public interface IDto
{
	int DbOperation { get; }

	Dictionary<string, string> Acl { get; }
	
	Guid? ConcurrencyToken { get; }
}
