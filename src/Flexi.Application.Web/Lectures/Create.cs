using FastEndpoints;
using Flexi.Application.Web.Endpoints.LectureEndpoints;
using MediatR;
using Flexi.Application.UseCases.Lectures.Create;

namespace Flexi.Application.Web.LectureEndpoints;

/// <summary>
/// Create a new Subject
/// </summary>
/// <remarks>
/// Creates a new Subject given a name.
/// </remarks>
public class Create(IMediator _mediator)
  : Endpoint<CreateLectureRequest, CreateLectureResponse>
{
  public override void Configure()
  {
    Post(CreateLectureRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new CreateLectureRequest 
      { 
        SubjectId = 1,
        TheatreId = 1,
        Day = "Mon",
        Time = "13:00",
        Duration = 30
      };
    });
  }

  public override async Task HandleAsync(
    CreateLectureRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new CreateLectureCommand(request.SubjectId, request.TheatreId, request.Day, request.Time, request.Duration));

    if(result.IsSuccess)
    {
      Response = new CreateLectureResponse(result.Value, request.Day, request.Time, request.Duration);
      return;
    }
    // TODO: Handle other cases as necessary
  }
}
