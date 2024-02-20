using Ardalis.Specification;

namespace Flexi.Application.Core.Aggregates.LectureTheatreAggregate.Specifications;

public class LectureTheatreByIdSpec : Specification<LectureTheatre>
{
  public LectureTheatreByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
