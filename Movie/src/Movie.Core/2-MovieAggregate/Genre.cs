using Ardalis.SmartEnum;

namespace Movie.Core.MovieAggreate;

public class Genre : SmartEnum<Genre>
{
  public static readonly Genre Action = new(nameof(Action), 1);
  public static readonly Genre Adventure = new(nameof(Adventure), 2);
  public static readonly Genre Animation = new(nameof(Animation), 3);
  public static readonly Genre Comedy = new(nameof(Comedy), 4);
  public static readonly Genre Drama = new(nameof(Drama), 5);
  public static readonly Genre Documentary = new(nameof(Documentary), 6);
  public static readonly Genre Fantasy = new(nameof(Fantasy), 7);
  public static readonly Genre ScienceFiction = new(nameof(ScienceFiction), 8);
  public static readonly Genre Horror = new(nameof(Horror), 9);
  public static readonly Genre Musical = new(nameof(Musical), 10);
  public static readonly Genre Romance = new(nameof(Romance), 11);
  public static readonly Genre Thriller = new(nameof(Thriller), 12);
  public static readonly Genre Western = new(nameof(Western), 13);


  protected Genre(string name, int value) : base(name, value) { }

}
