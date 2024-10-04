using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Movie.UseCases.Tags.List;

public class ListTagsHandler(IListTagsQueryService _query): IQueryHandler<ListTagsQuery, Result<IEnumerable<TagDTO>>>
{
  public async Task<Result<IEnumerable<TagDTO>>> Handle(ListTagsQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }

}
