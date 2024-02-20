using FastEndpoints;
using Flexi.Application.UseCases.Contributors.List;
using Flexi.Application.UseCases.Lectures.List;
using Flexi.Application.Web.ContributorEndpoints;
using Flexi.Application.Web.Endpoints.ContributorEndpoints;
using MediatR;

namespace Flexi.Application.Web.Lectures;

public class List(IMediator _mediator) : EndpointWithoutRequest<LectureListResponse>
{
  public override void Configure()
  {
    Get("/Lectures");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new ListLecturesQuery(null, null));

    if (result.IsSuccess)
    {
      Response = new LectureListResponse
      {
        ResponseLectures = result.Value
      };
    }
  }
}
