namespace Envelope.Model.Audit;

public interface IAuditEntry<TIdentity>
	where TIdentity : struct
{
	DateTime CreatedUtc { get; set; }
	TIdentity? IdUser { get; set; }
	int IdAuditType { get; set; }
	string TableName { get; set; }
	string PrimaryKey { get; set; }
	string? OldValues { get; set; }
	string? NewValues { get; set; }
	string? AffectedColumns { get; set; }
	Guid AuditCorrelationId { get; set; }
	string? CommandQueryName { get; set; }
	Guid? IdCommandQuery { get; set; }
	Guid? CorrelationId { get; set; }
}
