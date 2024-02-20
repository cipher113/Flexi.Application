using Flexi.Application.Core.Aggregates.SubjectAggregate;

namespace Flexi.Application.Web.Subjects;

public class EnrollStudentResponse(Subject subject)
{
  public Subject Subject { get; } = subject;
}
