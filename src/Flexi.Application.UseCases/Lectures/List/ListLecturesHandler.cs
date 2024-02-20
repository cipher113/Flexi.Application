using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.UseCases.Lectures.List;

public class ListLecturesHandler(IListLecturesQueryService _query)
  : IQueryHandler<ListLecturesQuery, Result<IEnumerable<LectureDTO>>>
{
  public async Task<Result<IEnumerable<LectureDTO>>> Handle(ListLecturesQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
