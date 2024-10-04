using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Movie.UseCases.Tags.List;

public record ListTagsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<TagDTO>>>;
