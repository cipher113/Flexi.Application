using Ardalis.Specification;

namespace Flexi.Application.Core.Aggregates.SubjectAggregate.Specifications;

public class SubjectByIdSpec : Specification<Subject>
{
  public SubjectByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
