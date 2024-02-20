using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Flexi.Application.UseCases.Students.Delete;
public record DeleteStudentCommand(int StudentId) : ICommand<Result>;
