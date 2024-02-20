using Flexi.Application.Core.Aggregates.LectureAggregate;
using Flexi.Application.UseCases.Lectures;

namespace Flexi.Application.Web.Lectures;

public class LectureListResponse
{
  public IEnumerable<LectureDTO> ResponseLectures { get; set; } = [];
}
