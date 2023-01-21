namespace Envelope.Model.Correlation;

#if NET6_0_OR_GREATER
[Envelope.Serializer.JsonPolymorphicConverter]
#endif
public interface ICorrelable
{
	Guid CorrelationId { get; set; }
}
