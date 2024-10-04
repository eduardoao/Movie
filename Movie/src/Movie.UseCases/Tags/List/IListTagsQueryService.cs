using Movie.UseCases.Tags;

namespace Movie.UseCases.Tags.List;

/// <summary>
/// Represents a service that will actually fetch the necessary data
/// Typically implemented in Infrastructure
/// </summary>
public interface IListTagsQueryService
{
  Task<IEnumerable<TagDTO>> ListAsync();
}
