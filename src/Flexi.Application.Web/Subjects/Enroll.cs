using FastEndpoints;
using Flexi.Application.UseCases.Subjects.Create;
using Flexi.Application.UseCases.Subjects.Enroll;
using Flexi.Application.Web.Endpoints.SubjectEndpoints;
using MediatR;

namespace Flexi.Application.Web.Subjects;

public class Enroll(IMediator _mediator)
  : Endpoint<EnrollStudentRequest, EnrollStudentResponse>
{
  public override void Configure()
  {
    Post(EnrollStudentRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new EnrollStudentRequest { SubjectId = 1, StudentId = 1 };
    });
  }

  public override async Task HandleAsync(
    EnrollStudentRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new EnrollStudentCommand(request.StudentId!, request.SubjectId!));

    if (result.IsSuccess)
    {
      Response = new EnrollStudentResponse(result);
      return;
    }
  }
}
