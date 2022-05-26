namespace Envelope.Model.Concurrence;

public interface IConcurrent
{
	Guid ConcurrencyToken { get; set; }
}
