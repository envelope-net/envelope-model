namespace Envelope.Model.Correlation;

public interface ICorrelable
{
	Guid CorrelationId { get; set; }
}
