using Ardalis.GuardClauses;
using System.Xml.Linq;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.SubjectAggregate;

namespace Flexi.Application.Core.Aggregates.StudentAggregate;
public class Student(string name) : EntityBase, IAggregateRoot
{
  public string Name { get; private set; } = Guard.Against.NullOrEmpty(name, nameof(name));
  private readonly List<Enrollment> _enrollments = new List<Enrollment>();

  public IEnumerable<Enrollment> Enrollments => _enrollments.AsReadOnly();

  // Constructor and methods for business logic

  public void EnrollInSubject(Subject subject)
  {
    // Implement enrollment logic, considering business rules
    // Ensure that subject enrollment doesn't violate any rules
    var enrollment = new Enrollment(this.Id, subject.Id);
    _enrollments.Add(enrollment);
  }
}
