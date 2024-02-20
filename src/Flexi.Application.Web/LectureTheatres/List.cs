using FastEndpoints;
using MediatR;
using Flexi.Application.UseCases.LectureTheatres.List;
using Flexi.Application.Web.LectureTheatres;
using Flexi.Application.Web.Endpoints.LectureTheatreEndpoints;

namespace Flexi.Application.Web.LectureTheatreEndpoints;

/// <summary>
/// List all LectureTheatres
/// </summary>
/// <remarks>
/// List all LectureTheatres - returns a LectureTheatreListResponse containing the LectureTheatres.
/// </remarks>
public class List(IMediator _mediator) : EndpointWithoutRequest<LectureTheatreListResponse>
{
  public override void Configure()
  {
    Get("/LectureTheatres");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new ListLectureTheatresQuery(null, null));

    if (result.IsSuccess)
    {
      Response = new LectureTheatreListResponse
      {
        LectureTheatres = result.Value.Select(c => new LectureTheatreRecord(c.Id, c.Name)).ToList()
      };
    }
  }
}
