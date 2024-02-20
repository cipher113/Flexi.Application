using Flexi.Application.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace Flexi.Application.Web.Endpoints.LectureEndpoints;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class CreateLectureValidator : Validator<CreateLectureRequest>
{
  public CreateLectureValidator()
  {
    RuleFor(x => x.Day)
      .NotEmpty()
      .WithMessage("Day is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);

    RuleFor(x => x.Time)
      .NotEmpty()
      .WithMessage("Time is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
  }
}
