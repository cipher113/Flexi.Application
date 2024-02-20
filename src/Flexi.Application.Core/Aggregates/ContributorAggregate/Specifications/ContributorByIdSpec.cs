using Ardalis.Specification;
using Flexi.Application.Core.Aggregates.ContributorAggregate;

namespace Flexi.Application.Core.Aggregates.ContributorAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
