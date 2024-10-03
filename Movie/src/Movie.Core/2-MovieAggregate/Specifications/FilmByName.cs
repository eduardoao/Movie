using Ardalis.Specification;
using Movie.Core.MovieAggreate;

namespace Movie.Core._2_MovieAggregate.Specifications;

public class MovieByName : Specification<Film>
{

  public MovieByName(string filmName)
  {
    Query.Where(film => film.Title == filmName);
  }

}
