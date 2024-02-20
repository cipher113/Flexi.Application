using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureTheatreAggregate;

namespace Flexi.Application.UseCases.LectureTheatres.List;
internal class ListLectureTheatresHandler(IReadRepository<LectureTheatre> _repository)
  : IQueryHandler<ListLectureTheatresQuery, Result<IEnumerable<LectureTheatre>>>
{
  public async Task<Result<IEnumerable<LectureTheatre>>> Handle(ListLectureTheatresQuery request, CancellationToken cancellationToken)
  {
    var entities = await _repository.ListAsync(cancellationToken);
    if (entities == null) return Result.NotFound();

    return entities;
  }
}
