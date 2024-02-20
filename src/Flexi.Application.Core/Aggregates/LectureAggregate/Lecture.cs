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
public class Lecture(int subjectId, int lectureTheatreId, LectureTime timeSlot) : EntityBase, IAggregateRoot
{
  public int SubjectId { get; set; } = Guard.Against.NegativeOrZero(subjectId, nameof(subjectId));
  public int LectureTheatreId { get; set; } = Guard.Against.NegativeOrZero(lectureTheatreId, nameof(lectureTheatreId));
  public LectureTime? TimeSlot { get; private set; } = timeSlot;
  public Subject? Subject { get; private set; }
  public LectureTheatre? LectureTheatre { get; private set; }
}
