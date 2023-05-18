using System.Runtime.Serialization;

namespace Envelope.Model.States;

public class InvalidStateTransitionException : Exception
{
	public InvalidStateTransitionException()
		: base()
	{
	}

	public InvalidStateTransitionException(string? message)
		: base(message)
	{
	}

	public InvalidStateTransitionException(string? message, Exception? innerException)
		: base(message, innerException)
	{
	}

	protected InvalidStateTransitionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
