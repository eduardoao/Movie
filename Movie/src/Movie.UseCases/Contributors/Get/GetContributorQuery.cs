using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Movie.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
