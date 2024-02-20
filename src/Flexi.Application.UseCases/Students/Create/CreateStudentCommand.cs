using Ardalis.Result;

namespace Flexi.Application.UseCases.Students.Create;
public record CreateStudentCommand(string Name) : Ardalis.SharedKernel.ICommand<Result<int>>;
