using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureTheatreAggregate;

namespace Flexi.Application.UseCases.LectureTheatres.List;
public record ListLectureTheatresQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<LectureTheatre>>>;
