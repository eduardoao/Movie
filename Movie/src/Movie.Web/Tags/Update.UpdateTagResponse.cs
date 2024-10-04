namespace Movie.Web.Tags;

public class UpdateTagResponse(TagRecord tag)
{
  public TagRecord Tag { get; set; } = tag;
}
