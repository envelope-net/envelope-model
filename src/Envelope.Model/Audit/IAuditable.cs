namespace Envelope.Model.Audit;

#if NET6_0_OR_GREATER
[Envelope.Serializer.JsonPolymorphicConverter]
#endif
public interface IAuditable
{
	DateTime AuditCreatedUtc { get; set; }
	Guid? IdAuditCreatedBy { get; set; }
	DateTime? AuditModifiedUtc { get; set; }
	Guid? IdAuditModifiedBy { get; set; }
}
