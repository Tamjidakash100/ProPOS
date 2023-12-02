using ProPOS.SharedKernel.Common;

namespace ProPOS.SharedKernel.Interfaces;

public interface IDomainEventDispatcher<TId>
{
    Task DispatchAndClearEvents(IEnumerable<BaseEntity<TId>> entitiesWithEvents);
}