using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.ContributorAggregate;
using Flexi.Application.UseCases.Contributors.Get;
using Flexi.Application.UseCases.Contributors;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.UseCases.Students.List;
internal class ListSubjectHandler(IReadRepository<Student> _repository)
  : IQueryHandler<ListSubjectQuery, Result<IEnumerable<Student>>>
{
  public async Task<Result<IEnumerable<Student>>> Handle(ListSubjectQuery request, CancellationToken cancellationToken)
  {
    var entities = await _repository.ListAsync(cancellationToken);
    if (entities == null) return Result.NotFound();

    return entities;
  }
}
