using Flexi.Application.Web.LectureTheatres;

namespace Flexi.Application.Web.Endpoints.LectureTheatreEndpoints;

public class LectureTheatreListResponse
{
  public List<LectureTheatreRecord> LectureTheatres { get; set; } = new();
}
