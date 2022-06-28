namespace Envelope.Model;

public interface IDto
{
	int DbOperation { get; }

	Dictionary<string, string> Acl { get; }
	
	Guid? ConcurrencyToken { get; }
}
