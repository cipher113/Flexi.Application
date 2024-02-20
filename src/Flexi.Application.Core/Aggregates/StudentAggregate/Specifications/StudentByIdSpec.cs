using Ardalis.Specification;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.Core.Aggregates.StudentAggregate.Specifications;

public class StudentByIdSpec : Specification<Student>
{
  public StudentByIdSpec(int studentId)
  {
    Query
        .Include(s => s.Enrollments)
          .ThenInclude(e => e.Subject)
          .ThenInclude(s => s!.Lectures)
        .Where(s => s.Id == studentId);
  }
}
