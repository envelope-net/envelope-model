namespace Envelope.Model.Audit;

public interface IAuditable
{
	DateTime AuditCreatedUtc { get; set; }
	Guid? IdAuditCreatedBy { get; set; }
	DateTime? AuditModifiedUtc { get; set; }
	Guid? IdAuditModifiedBy { get; set; }
}
