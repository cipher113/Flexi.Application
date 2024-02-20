using System.ComponentModel.DataAnnotations;

namespace Flexi.Application.Web.Subjects;

public class EnrollStudentRequest
{
  public const string Route = "/Enroll";

  [Required]
  public int SubjectId { get; set; }

  [Required]
  public int StudentId { get; set; }
}
