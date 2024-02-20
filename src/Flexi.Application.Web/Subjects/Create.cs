using FastEndpoints;
using Flexi.Application.Web.Endpoints.SubjectEndpoints;
using MediatR;
using Flexi.Application.UseCases.Subjects.Create;

namespace Flexi.Application.Web.SubjectEndpoints;

/// <summary>
/// Create a new Subject
/// </summary>
/// <remarks>
/// Creates a new Subject given a name.
/// </remarks>
public class Create(IMediator _mediator)
  : Endpoint<CreateSubjectRequest, CreateSubjectResponse>
{
  public override void Configure()
  {
    Post(CreateSubjectRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new CreateSubjectRequest { Name = "Subject Name" };
    });
  }

  public override async Task HandleAsync(
    CreateSubjectRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new CreateLectureTheatreCommand(request.Name!));

    if(result.IsSuccess)
    {
      Response = new CreateSubjectResponse(result.Value, request.Name!);
      return;
    }
    // TODO: Handle other cases as necessary
  }
}
