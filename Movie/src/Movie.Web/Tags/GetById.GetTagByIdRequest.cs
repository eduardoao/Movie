namespace Movie.Web.Tags;

public class GetTagByIdRequest
{
  public const string Route = "/Tags/{TagId:int}";
  public static string BuildRoute(int tagId) => Route.Replace("{TagId:int}", tagId.ToString());

  public int TagId { get; set; }
}
