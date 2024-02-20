namespace Flexi.Application.Web.Endpoints.LectureTheatreEndpoints;

public class CreateLectureTheatreResponse
{
  public CreateLectureTheatreResponse(int id, string name, int capacity)
  {
    Id = id;
    Name = name;
    Capacity = capacity;
  }
  public int Id { get; set; }
  public string Name { get; set; }
  public int Capacity { get; set; }
}
