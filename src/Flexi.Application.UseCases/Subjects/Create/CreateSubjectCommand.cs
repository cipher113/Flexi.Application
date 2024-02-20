using Ardalis.Result;

namespace Flexi.Application.UseCases.Subjects.Create;
public record CreateSubjectCommand(string Name) : Ardalis.SharedKernel.ICommand<Result<int>>;
