using Ardalis.Result;
using Flexi.Application.Core.Aggregates.SubjectAggregate;

namespace Flexi.Application.UseCases.Subjects.Enroll;
public record EnrollStudentCommand(int StudentId, int SubjectId) : Ardalis.SharedKernel.ICommand<Result<Subject>>;
