using ProPOS.SharedKernel.Common;

namespace ProPOS.SharedKernel.Entities;

public class Country: AuditableEntity
{
    public string Name { get; set; }=String.Empty;
}