using FastEndpoints;
using Flexi.Application.Web.Endpoints.LectureTheatreEndpoints;
using MediatR;
using Flexi.Application.UseCases.LectureTheatres.Create;

namespace Flexi.Application.Web.LectureTheatreEndpoints;

/// <summary>
/// Create a new LectureTheatre
/// </summary>
/// <remarks>
/// Creates a new LectureTheatre given a name.
/// </remarks>
public class Create(IMediator _mediator)
  : Endpoint<CreateLectureTheatreRequest, CreateLectureTheatreResponse>
{
  public override void Configure()
  {
    Post(CreateLectureTheatreRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new CreateLectureTheatreRequest { Name = "LectureTheatre Name" };
    });
  }

  public override async Task HandleAsync(
    CreateLectureTheatreRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new CreateLectureTheatreCommand(request.Name!, request.Capacity));

    if(result.IsSuccess)
    {
      Response = new CreateLectureTheatreResponse(result.Value, request.Name!, request.Capacity!);
      return;
    }
    // TODO: Handle other cases as necessary
  }
}
