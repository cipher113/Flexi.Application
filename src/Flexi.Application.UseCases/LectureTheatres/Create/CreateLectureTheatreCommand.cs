using Ardalis.Result;

namespace Flexi.Application.UseCases.LectureTheatres.Create;
public record CreateLectureTheatreCommand(string Name, int Capacity) : Ardalis.SharedKernel.ICommand<Result<int>>;
