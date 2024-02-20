using Flexi.Application.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace Flexi.Application.Web.Endpoints.LectureTheatreEndpoints;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class CreateLectureTheatreValidator : Validator<CreateLectureTheatreRequest>
{
  public CreateLectureTheatreValidator()
  {
    RuleFor(x => x.Name)
      .NotEmpty()
      .WithMessage("Name is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
  }
}
