using MediatR;

namespace ProPOS.SharedKernel.Common;

public class DomainEventBase : INotification
{
    public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;

}