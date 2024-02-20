using Ardalis.Result;
using Flexi.Application.Core.Aggregates.LectureAggregate;

namespace Flexi.Application.UseCases.Lectures.Create;
public record CreateLectureCommand(int SubjectId, int TheatreId, string Day, string Time, int Duration) : Ardalis.SharedKernel.ICommand<Result<int>>;
