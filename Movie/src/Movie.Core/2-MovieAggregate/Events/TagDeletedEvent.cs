using Ardalis.SharedKernel;

namespace Movie.Core._2_MovieAggregate.Events;

internal sealed class TagDeletedEvent(int tagIdId) : DomainEventBase
{
  public int TagId { get; init; } = tagIdId;
}
