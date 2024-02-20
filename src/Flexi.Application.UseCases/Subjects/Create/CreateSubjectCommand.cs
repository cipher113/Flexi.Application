using Ardalis.Result;

namespace Flexi.Application.UseCases.Subjects.Create;
public record CreateLectureTheatreCommand(string Name) : Ardalis.SharedKernel.ICommand<Result<int>>;
