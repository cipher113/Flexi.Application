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
}
