using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.SubjectAggregate;

namespace Flexi.Application.UseCases.Subjects.Create;
public class CreateLectureTheatreHandler(IRepository<Subject> _repository)
  : ICommandHandler<CreateLectureTheatreCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateLectureTheatreCommand request, CancellationToken cancellationToken)
  {
    var newStudent = new Subject(request.Name);
    var createdItem = await _repository.AddAsync(newStudent, cancellationToken);

    return createdItem.Id;
  }
}
