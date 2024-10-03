using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Movie.Core._2_MovieAggregate;

namespace Movie.Core.MovieAggreate;

public class Movie(string title): EntityBase, IAggregateRoot
{  
  public string Title { get; private set; }  = Guard.Against.NullOrEmpty(title, nameof(title));
  public string? OriginalTitle { get; private set; } 
  public string? Overview { get; private set; }
  public string?  Poster { get; private set; }
  public DateTime ReleaseDate { get; private set; }
  public string? Trailler { get; private set; }
  public Genre[]? Genres { get; private set; }   
  public Tag[]? Tags { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public PersonStatus[]? Persons { get; private set; }
  

  



}
