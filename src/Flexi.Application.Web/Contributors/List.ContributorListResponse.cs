using Flexi.Application.Web.ContributorEndpoints;

namespace Flexi.Application.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
