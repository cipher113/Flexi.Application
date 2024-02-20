using FastEndpoints;
using Flexi.Application.Infrastructure.Data.Config;
using FluentValidation;

namespace Flexi.Application.Web.Subjects;

public class EnrollStudentValidator : Validator<EnrollStudentRequest>
{
  public EnrollStudentValidator()
  {
    RuleFor(x => x.StudentId)
      .GreaterThan(0)
      .WithMessage("StudentId is required");

    RuleFor(x => x.SubjectId)
      .GreaterThan(0)
      .WithMessage("StudentId is required");
  }
}
