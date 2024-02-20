namespace Flexi.Application.Web.Endpoints.SubjectEndpoints;

public class CreateSubjectResponse(int id, string name)
{
  public int Id { get; set; } = id;
  public string Name { get; set; } = name;
}
