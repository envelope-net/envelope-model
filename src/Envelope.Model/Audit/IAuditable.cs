namespace Envelope.Model.Audit;

public interface IAuditable<TIdentity>
	where TIdentity : struct
{
	DateTime AuditCreatedUtc { get; set; }
	TIdentity? IdAuditCreatedBy { get; set; }
	DateTime? AuditModifiedUtc { get; set; }
	TIdentity? IdAuditModifiedBy { get; set; }
}
