using FastEndpoints;
using Flexi.Application.Web.Endpoints.StudentEndpoints;
using MediatR;
using Flexi.Application.UseCases.Students.Create;

namespace Flexi.Application.Web.StudentEndpoints;

/// <summary>
/// Create a new Student
/// </summary>
/// <remarks>
/// Creates a new Student given a name.
/// </remarks>
public class Create(IMediator _mediator)
  : Endpoint<CreateStudentRequest, CreateStudentResponse>
{
  public override void Configure()
  {
    Post(CreateStudentRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new CreateStudentRequest { Name = "Student Name" };
    });
  }

  public override async Task HandleAsync(
    CreateStudentRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new CreateSubjectCommand(request.Name!));

    if(result.IsSuccess)
    {
      Response = new CreateStudentResponse(result.Value, request.Name!);
      return;
    }
    // TODO: Handle other cases as necessary
  }
}
