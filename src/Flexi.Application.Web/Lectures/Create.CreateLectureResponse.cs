using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.Web.Endpoints.LectureEndpoints;

public class CreateLectureResponse(int id, string day, string time, int duration)
{
  public int Id { get; set; } = id;
  public string? Day { get; set; } = day;
  public string? Time { get; set; } = time;
  public int Duration { get; set; } = duration;
}
