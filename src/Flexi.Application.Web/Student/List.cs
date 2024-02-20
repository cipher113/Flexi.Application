using FastEndpoints;
using MediatR;
using Flexi.Application.UseCases.Students.List;
using Flexi.Application.Web.Student;
using Flexi.Application.Web.Endpoints.StudentEndpoints;

namespace Flexi.Application.Web.StudentEndpoints;

/// <summary>
/// List all Students
/// </summary>
/// <remarks>
/// List all Students - returns a StudentListResponse containing the Students.
/// </remarks>
public class List(IMediator _mediator) : EndpointWithoutRequest<StudentListResponse>
{
  public override void Configure()
  {
    Get("/Students");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new ListSubjectQuery(null, null));

    if (result.IsSuccess)
    {
      Response = new StudentListResponse
      {
        Students = result.Value.Select(c => new SubjectRecord(c.Id, c.Name)).ToList()
      };
    }
  }
}
