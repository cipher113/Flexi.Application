using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureTheatreAggregate;

namespace Flexi.Application.UseCases.LectureTheatres.Create;
public class CreateLectureTheatreHandler(IRepository<LectureTheatre> _repository)
  : ICommandHandler<CreateLectureTheatreCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateLectureTheatreCommand request, CancellationToken cancellationToken)
  {
    var newLectureTheatre = new LectureTheatre(request.Name, request.Capacity);
    var createdItem = await _repository.AddAsync(newLectureTheatre, cancellationToken);

    return createdItem.Id;
  }
}
