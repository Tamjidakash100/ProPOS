using ProPOS.SharedKernel.Interfaces;

namespace ProPOS.SharedKernel.Common;

public abstract class AuditableEntity<TId> : BaseEntity<TId>, IAggregateRoot
{
    public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
    public long CreatedBy { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTimeOffset? ModifiedDate { get; set; }
    public long? ModifiedBy { get; set; }
    public bool IsDelete { get; set; } = false;
}
// abstract class
public abstract class AuditableEntity : AuditableEntity<long>
{
}