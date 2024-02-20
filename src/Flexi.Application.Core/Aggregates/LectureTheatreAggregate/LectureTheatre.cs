using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.Core.Aggregates.LectureTheatreAggregate;
public class LectureTheatre(string name, int capacity) : EntityBase, IAggregateRoot
{
  public string Name { get; set; } = Guard.Against.NullOrEmpty(name, nameof(name));
  public int Capacity { get; set; } = Guard.Against.NegativeOrZero(capacity, nameof(capacity));
  public List<Lecture> Lectures { get; set; } = [];
}
