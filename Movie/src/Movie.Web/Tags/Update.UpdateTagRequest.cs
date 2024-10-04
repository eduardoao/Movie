using System.ComponentModel.DataAnnotations;

namespace Movie.Web.Tags;

public class UpdateTagRequest
{
  public const string Route = "/Tags/{TagId:int}";
  public static string BuildRoute(int tagId) => Route.Replace("{TagId:int}", tagId.ToString());

  public int TagId { get; set; }

  [Required]
  public int Id { get; set; }
  [Required]
  public string? Title { get; set; }
}
