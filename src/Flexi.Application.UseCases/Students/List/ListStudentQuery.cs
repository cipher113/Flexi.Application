using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.StudentAggregate;

namespace Flexi.Application.UseCases.Students.List;
public record ListSubjectQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<Student>>>;
