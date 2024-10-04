namespace Movie.Web.Contributors;

public class CreateTagResponse(int id, string title)
{
  public int Id { get; set; } = id;
  public string Title { get; set; } = title;
}
