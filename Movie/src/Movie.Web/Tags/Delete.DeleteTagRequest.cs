public record DeleteTagRequest
{
  public const string Route = "/Tags/{TagId:int}";
  public static string BuildRoute(int TagId) => Route.Replace("{TagId:int}", TagId.ToString());

  public int TagId { get; set; }
}
