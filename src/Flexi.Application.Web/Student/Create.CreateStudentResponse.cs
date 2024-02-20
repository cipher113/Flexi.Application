namespace Flexi.Application.Web.Endpoints.StudentEndpoints;

public class CreateStudentResponse
{
  public CreateStudentResponse(int id, string name)
  {
    Id = id;
    Name = name;
  }
  public int Id { get; set; }
  public string Name { get; set; }
}
