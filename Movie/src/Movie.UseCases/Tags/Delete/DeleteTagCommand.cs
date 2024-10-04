using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Movie.UseCases.Tags.Delete;

public record DeleteTagCommand(int TagId) : ICommand<Result>;
