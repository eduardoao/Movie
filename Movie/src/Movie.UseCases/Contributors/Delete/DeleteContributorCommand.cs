using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Movie.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
