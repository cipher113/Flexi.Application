using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.UseCases.Lectures.Create;
public class CreateLectureHandler(IRepository<Lecture> _repository)
  : ICommandHandler<CreateLectureCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateLectureCommand request, CancellationToken cancellationToken)
  {
    var timeSlot = new LectureTime(request.Day, request.Time, request.Duration);
    var newLecture = new Lecture(request.SubjectId, request.TheatreId, request.Day, request.Time, request.Duration);
    var createdItem = await _repository.AddAsync(newLecture, cancellationToken);

    return createdItem.Id;
  }
}
