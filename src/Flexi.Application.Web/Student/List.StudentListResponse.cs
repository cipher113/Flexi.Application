using Flexi.Application.Web.Student;

namespace Flexi.Application.Web.Endpoints.StudentEndpoints;

public class StudentListResponse
{
  public List<SubjectRecord> Students { get; set; } = new();
}
