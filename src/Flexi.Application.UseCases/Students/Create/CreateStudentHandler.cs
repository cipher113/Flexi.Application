using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.UseCases.Students.Create;
public class CreateStudentHandler(IRepository<Student> _repository)
  : ICommandHandler<CreateStudentCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
  {
    var newStudent = new Student(request.Name);
    var createdItem = await _repository.AddAsync(newStudent, cancellationToken);

    return createdItem.Id;
  }
}
