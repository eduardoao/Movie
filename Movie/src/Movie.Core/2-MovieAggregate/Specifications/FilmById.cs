using Ardalis.Specification;
using Movie.Core.MovieAggreate;

namespace Movie.Core._2_MovieAggregate.Specifications;

public class FilmById: Specification<Film>
{
  public FilmById(int id)
  {
    Query.Where (film => film.Id == id);
  }

}
