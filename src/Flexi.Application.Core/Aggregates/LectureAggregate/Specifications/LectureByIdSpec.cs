using Ardalis.Specification;
using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.Core.Aggregates.LectureAggregate.Specifications;

public class LectureByIdSpec : Specification<Lecture>
{
  public LectureByIdSpec(int id)
  {
    Query
        .Where(lecture => lecture.Id == id);
  }
}
