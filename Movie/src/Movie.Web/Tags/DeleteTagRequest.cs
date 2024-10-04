
public record DeleteTagRequest
{
  public const string Route = "/Tags/{TagId:int}";
  public static string BuildRoute(int tagId) => Route.Replace("{ContributorId:int}", tagId.ToString());

  public int TagId { get; set; }
}
