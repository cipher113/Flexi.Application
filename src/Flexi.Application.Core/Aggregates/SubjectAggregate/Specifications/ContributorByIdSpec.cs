using Ardalis.Specification;
using Flexi.Application.Core.Aggregates.ContributorAggregate;

namespace Flexi.Application.Core.Aggregates.ContributorAggregate.Specifications;

public class LectureByIdSpec : Specification<Contributor>
{
  public LectureByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
