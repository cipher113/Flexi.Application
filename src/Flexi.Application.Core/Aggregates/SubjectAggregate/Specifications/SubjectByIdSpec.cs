using Ardalis.Specification;

namespace Flexi.Application.Core.Aggregates.SubjectAggregate.Specifications;

public class SubjectByIdSpec : Specification<Subject>
{
  public SubjectByIdSpec(int subjectId)
  {
    Query
        .Include(s => s.Lectures)
          .ThenInclude(l=>l.LectureTheatre)
        .Include(s => s.Enrollments)
        .Where(s => s.Id == subjectId);
  }
}
