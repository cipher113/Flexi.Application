using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureTheatreAggregate;
using Flexi.Application.Core.Aggregates.SubjectAggregate;

namespace Flexi.Application.Core.Aggregates.LectureAggregate;
public class Lecture(int subjectId, int lectureTheatreId, string day, string time, int duration) : EntityBase, IAggregateRoot
{
  public int SubjectId { get; set; } = Guard.Against.NegativeOrZero(subjectId, nameof(subjectId));
  public int LectureTheatreId { get; set; } = Guard.Against.NegativeOrZero(lectureTheatreId, nameof(lectureTheatreId));
  //public LectureTime? TimeSlot { get; private set; } = timeSlot;
  public string Day { get; private set; } = Guard.Against.NullOrEmpty(day, nameof(day));
  public string Time { get; private set; } = Guard.Against.NullOrEmpty(time, nameof(time));
  public int Duration { get; private set; } = Guard.Against.NegativeOrZero(duration, nameof(duration));
  public Subject? Subject { get; private set; }
  public LectureTheatre? LectureTheatre { get; private set; }
}
