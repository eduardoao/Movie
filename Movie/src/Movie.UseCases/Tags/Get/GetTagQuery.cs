using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Movie.UseCases.Tags.Get;

public record GetTagQuery(int TagId) : IQuery<Result<TagDTO>>;
