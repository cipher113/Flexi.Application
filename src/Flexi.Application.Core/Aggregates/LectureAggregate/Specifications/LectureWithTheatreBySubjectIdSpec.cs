using Ardalis.Specification;
using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.Core.Aggregates.LectureAggregate.Specifications;

public class LectureWithTheatreBySubjectIdSpec : Specification<Lecture>
{
  public LectureWithTheatreBySubjectIdSpec(int id)
  {
    Query
        .Include(lecture => lecture.LectureTheatre)
        .Where(lecture => lecture.SubjectId == id);
  }
}
