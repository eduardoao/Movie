using Ardalis.Specification;
using Movie.Core._1_ContributorAggregate;

namespace Movie.Core.ContributorAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>
{
  public ContributorByIdSpec(int contributorId)
  {
    Query.Where(contributor => contributor.Id == contributorId);
  }
}
