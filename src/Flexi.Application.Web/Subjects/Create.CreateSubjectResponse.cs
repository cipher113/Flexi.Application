namespace Flexi.Application.Web.Endpoints.SubjectEndpoints;

public class CreateSubjectResponse
{
  public CreateSubjectResponse(int id, string name)
  {
    Id = id;
    Name = name;
  }
  public int Id { get; set; }
  public string Name { get; set; }
}
