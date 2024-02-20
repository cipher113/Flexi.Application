using Flexi.Application.Web.Student;

namespace Flexi.Application.Web.Endpoints.StudentEndpoints;

public class StudentListResponse
{
  public List<StudentRecord> Students { get; set; } = new();
}
