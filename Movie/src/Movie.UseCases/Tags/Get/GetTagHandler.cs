using Ardalis.Result;
using Ardalis.SharedKernel;
using Movie.Core._2_MovieAggregate;
using Movie.Core._2_MovieAggregate.Specifications;
using Movie.UseCases.Tags;
using Movie.UseCases.Tags.Get;

namespace Movie.UseCases.Contributors.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetTagHandler(IReadRepository<Tag> _repository): IQueryHandler<GetTagQuery, Result<TagDTO>>
{
  public async Task<Result<TagDTO>> Handle(GetTagQuery request, CancellationToken cancellationToken)
  {
    var spec = new TagById(request.TagId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new TagDTO(entity.Id, entity.Title, entity.Enable);
  }
}
