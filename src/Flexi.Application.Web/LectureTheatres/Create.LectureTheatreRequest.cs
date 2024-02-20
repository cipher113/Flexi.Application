using System.ComponentModel.DataAnnotations;

namespace Flexi.Application.Web.Endpoints.LectureTheatreEndpoints;

public class CreateLectureTheatreRequest
{
  public const string Route = "/LectureTheatres";

  [Required]
  public string? Name { get; set; }
  [Required]
  public int Capacity { get; set; }
}
