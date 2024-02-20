using Ardalis.Specification;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.Core.Aggregates.StudentAggregate.Specifications;

public class StudentByIdSpec : Specification<Student>
{
  public StudentByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
