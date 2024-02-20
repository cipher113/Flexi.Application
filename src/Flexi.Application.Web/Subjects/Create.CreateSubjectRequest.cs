using System.ComponentModel.DataAnnotations;

namespace Flexi.Application.Web.Endpoints.SubjectEndpoints;

public class CreateSubjectRequest
{
  public const string Route = "/Subjects";

  [Required]
  public string? Name { get; set; }
}
