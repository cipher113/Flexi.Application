using Ardalis.GuardClauses;

namespace Flexi.Application.Core.Aggregates.LectureAggregate;
public class LectureTime(string day, string time, int duration)
{
  public string Day { get; private set; } = Guard.Against.NullOrEmpty(day, nameof(day));
  public string Time { get; private set; } = Guard.Against.NullOrEmpty(time, nameof(time));
  public int Duration { get; private set; } = Guard.Against.NegativeOrZero(duration, nameof(duration));
}
