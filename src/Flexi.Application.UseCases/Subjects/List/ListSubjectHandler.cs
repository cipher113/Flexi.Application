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
using Flexi.Application.Core.Aggregates.SubjectAggregate;

namespace Flexi.Application.UseCases.Subjects.List;
internal class ListLectureTheatresHandler(IReadRepository<Subject> _repository)
  : IQueryHandler<ListSubjectQuery, Result<IEnumerable<Subject>>>
{
  public async Task<Result<IEnumerable<Subject>>> Handle(ListSubjectQuery request, CancellationToken cancellationToken)
  {
    var entities = await _repository.ListAsync(cancellationToken);
    if (entities == null) return Result.NotFound();

    return entities;
  }
}
