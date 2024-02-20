using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureAggregate;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.Core.Aggregates.SubjectAggregate;
public class Subject(string name) : EntityBase, IAggregateRoot
{
  public string Name { get; private set; } = Guard.Against.NullOrEmpty(name, nameof(name));
  private readonly List<Lecture> _lectures = new List<Lecture>();
  private readonly List<Enrollment> _enrollments = new List<Enrollment>();

  public IEnumerable<Lecture> Lectures => _lectures.AsReadOnly();
  public IEnumerable<Enrollment> Enrollments => _enrollments.AsReadOnly();

  // Constructor and methods for bus2iness logic

  public void ScheduleLecture(Lecture lecture)
  {
    // Implement scheduling logic, considering business rules
    // Ensure that lecture scheduling doesn't violate any rules
    _lectures.Add(lecture);
  }
}
