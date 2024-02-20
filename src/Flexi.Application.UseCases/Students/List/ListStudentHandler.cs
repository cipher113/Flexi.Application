using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.UseCases.Students.List;
internal class ListSubjectHandler(IReadRepository<Student> _repository)
  : IQueryHandler<ListStudentQuery, Result<IEnumerable<Student>>>
{
  public async Task<Result<IEnumerable<Student>>> Handle(ListStudentQuery request, CancellationToken cancellationToken)
  {
    var entities = await _repository.ListAsync(cancellationToken);
    if (entities == null) return Result.NotFound();

    return entities;
  }
}
