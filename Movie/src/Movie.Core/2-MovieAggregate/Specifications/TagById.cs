using Ardalis.Specification;
using Movie.Core.MovieAggreate;

namespace Movie.Core._2_MovieAggregate.Specifications;

public class TagById : Specification<Tag>
{

  public TagById(int tagId)
  {
    Query.Where(tag => tag.Id == tagId);
  }

}
