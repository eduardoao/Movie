using Ardalis.Specification;
using Movie.Core.MovieAggreate;

namespace Movie.Core._2_MovieAggregate.Specifications;

public class FilmByName : Specification<Film>
{

  public FilmByName(string filmName)
  {
    Query.Where(film => film.Title == filmName);
  }

}
