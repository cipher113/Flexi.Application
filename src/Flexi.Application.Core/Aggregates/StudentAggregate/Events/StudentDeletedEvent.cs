using Ardalis.SharedKernel;

namespace Flexi.Application.Core.Aggregates.StudentAggregate.Events;

/// <summary>
/// A domain event that is dispatched whenever a contributor is deleted.
/// The DeleteContributorService is used to dispatch this event.
/// </summary>
internal sealed class StudentDeletedEvent(int studentId) : DomainEventBase
{
  public int StudentId { get; init; } = studentId;
}
