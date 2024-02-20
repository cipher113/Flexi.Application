using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Flexi.Application.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
