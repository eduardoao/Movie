using Ardalis.Result;

namespace Movie.UseCases.Tags.Create;

public record CreateTagCommand(string Title, CancellationToken cancellationToken) : Ardalis.SharedKernel.ICommand<Result<int>>;
