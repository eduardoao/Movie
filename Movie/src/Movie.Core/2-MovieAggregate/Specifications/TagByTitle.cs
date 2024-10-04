using Ardalis.Specification;
using Movie.Core.MovieAggreate;

namespace Movie.Core._2_MovieAggregate.Specifications;

public class TagByTitle: Specification<Tag>
{
  public TagByTitle(string title)
  {
    Query.Where (tag => tag.Title == title);
  }

}
