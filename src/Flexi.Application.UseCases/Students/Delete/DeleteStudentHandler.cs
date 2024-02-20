using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Interfaces;
using Flexi.Application.UseCases.Contributors.Delete;

namespace Flexi.Application.UseCases.Students.Delete;
public class DeleteStudentHandler(IDeleteContributorService _deleteContributorService)
  : ICommandHandler<DeleteStudentCommand, Result>
{
  public async Task<Result> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
  {
    return await _deleteContributorService.DeleteContributor(request.StudentId);
  }
}
