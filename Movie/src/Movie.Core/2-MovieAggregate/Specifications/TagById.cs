using Ardalis.Specification;

namespace Movie.Core._2_MovieAggregate.Specifications;

public class TagById : Specification<Tag>
{

  public TagById(int tagId)
  {
    Query.Where(tag => tag.Id == tagId);
  }

}
