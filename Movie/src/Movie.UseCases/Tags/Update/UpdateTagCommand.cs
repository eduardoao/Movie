using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Movie.UseCases.Tags.Update;

public record UpdateTagCommand(int TagId, string NewTitle) : ICommand<Result<TagDTO>>;
