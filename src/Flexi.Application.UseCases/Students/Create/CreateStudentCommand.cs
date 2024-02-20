using Ardalis.Result;

namespace Flexi.Application.UseCases.Students.Create;
public record CreateSubjectCommand(string Name) : Ardalis.SharedKernel.ICommand<Result<int>>;
