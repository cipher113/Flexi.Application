using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.UseCases.Lectures.List;

/// <summary>
/// Represents a service that will actually fetch the necessary data
/// Typically implemented in Infrastructure
/// </summary>
public interface IListLecturesQueryService
{
  Task<IEnumerable<LectureDTO>> ListAsync();
}
