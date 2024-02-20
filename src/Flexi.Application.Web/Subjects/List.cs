using FastEndpoints;
using MediatR;
using Flexi.Application.UseCases.Subjects.List;
using Flexi.Application.Web.Subjects;
using Flexi.Application.Web.Endpoints.SubjectEndpoints;

namespace Flexi.Application.Web.SubjectEndpoints;

/// <summary>
/// List all Subjects
/// </summary>
/// <remarks>
/// List all Subjects - returns a SubjectListResponse containing the Subjects.
/// </remarks>
public class List(IMediator _mediator) : EndpointWithoutRequest<SubjectListResponse>
{
  public override void Configure()
  {
    Get("/Subjects");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new ListSubjectQuery(null, null));

    if (result.IsSuccess)
    {
      Response = new SubjectListResponse
      {
        Subjects = result.Value.Select(c => new SubjectRecord(c.Id, c.Name)).ToList()
      };
    }
  }
}
