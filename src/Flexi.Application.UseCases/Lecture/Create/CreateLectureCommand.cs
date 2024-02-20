using Ardalis.Result;

namespace Flexi.Application.UseCases.Subjects.Create;
public record CreateLectureCommand(string Name) : Ardalis.SharedKernel.ICommand<Result<int>>;
