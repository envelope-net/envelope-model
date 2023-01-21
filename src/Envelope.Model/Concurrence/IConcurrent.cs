namespace Envelope.Model.Concurrence;

#if NET6_0_OR_GREATER
[Envelope.Serializer.JsonPolymorphicConverter]
#endif
public interface IConcurrent
{
	Guid ConcurrencyToken { get; set; }
}
