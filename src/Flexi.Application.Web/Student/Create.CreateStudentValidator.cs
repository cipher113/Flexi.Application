using Flexi.Application.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace Flexi.Application.Web.Endpoints.StudentEndpoints;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class CreateStudentValidator : Validator<CreateStudentRequest>
{
  public CreateStudentValidator()
  {
    RuleFor(x => x.Name)
      .NotEmpty()
      .WithMessage("Name is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
  }
}
