using Ardalis.Specification;
using Movie.Core.MovieAggreate;

namespace Movie.Core._2_MovieAggregate.Specifications;

public class TagById : Specification<Tag>
{

  public TagById(string tagId)
  {
    Query.Where(tag => tag.Title == tagId);
  }

}
