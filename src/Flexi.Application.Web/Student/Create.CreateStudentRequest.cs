using System.ComponentModel.DataAnnotations;

namespace Flexi.Application.Web.Endpoints.StudentEndpoints;

public class CreateStudentRequest
{
  public const string Route = "/Students";

  [Required]
  public string? Name { get; set; }
}
