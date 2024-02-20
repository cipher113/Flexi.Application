using System.ComponentModel.DataAnnotations;

namespace Flexi.Application.Web.Endpoints.LectureEndpoints;

public class CreateLectureRequest
{
  public const string Route = "/Lectures";

  [Required]
  public int SubjectId { get; set; }
  [Required]
  public int TheatreId { get; set; }
  [Required]
  public required string Day { get; set; }
  [Required]
  public required string Time { get; set; }
  [Required]
  public int Duration { get; set; }
}
