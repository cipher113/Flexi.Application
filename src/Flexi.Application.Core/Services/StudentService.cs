using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.ContributorAggregate;
using Flexi.Application.Core.Aggregates.ContributorAggregate.Events;
using Flexi.Application.Core.Aggregates.StudentAggregate;
using Flexi.Application.Core.Aggregates.StudentAggregate.Events;
using Flexi.Application.Core.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Flexi.Application.Core.Services;
public class StudentService(IRepository<Student> _repository,
  IMediator _mediator,
  ILogger<StudentService> _logger) : IStudentService
{
  public async Task<Result> DeleteStudent(int studentId)
  {
    _logger.LogInformation("Deleting Contributor {studentId}", studentId);
    var aggregateToDelete = await _repository.GetByIdAsync(studentId);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new StudentDeletedEvent(studentId);
    await _mediator.Publish(domainEvent);
    return Result.Success();
  }
}
