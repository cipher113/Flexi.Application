using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.UseCases.Lectures.List;

public record ListLecturesQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<LectureDTO>>>;
