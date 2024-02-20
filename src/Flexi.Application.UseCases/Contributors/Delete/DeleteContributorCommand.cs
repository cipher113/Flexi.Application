using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Flexi.Application.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
