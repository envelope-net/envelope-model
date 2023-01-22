namespace Envelope.Model.Audit;

#if NET6_0_OR_GREATER
[Envelope.Serializer.JsonPolymorphicConverter]
#endif
public interface IAuditable<TIdentity>
	where TIdentity : struct
{
	DateTime AuditCreatedUtc { get; set; }
	TIdentity? IdAuditCreatedBy { get; set; }
	DateTime? AuditModifiedUtc { get; set; }
	TIdentity? IdAuditModifiedBy { get; set; }
}
