using System.Text.Json.Serialization;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.Core.Aggregates.SubjectAggregate;
public class Enrollment(int studentId, int subjectId) : EntityBase
{
  public int StudentId { get; private set; } = Guard.Against.NegativeOrZero(studentId, nameof(studentId));
  public int SubjectId { get; private set; } = Guard.Against.NegativeOrZero(subjectId, nameof(subjectId));

  [JsonIgnore]
  public Student? Student { get; private set; }
  [JsonIgnore]
  public Subject? Subject { get; private set; }
}
