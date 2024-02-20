using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.SubjectAggregate;

namespace Flexi.Application.UseCases.Subjects.List;
public record ListSubjectQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<Subject>>>;
