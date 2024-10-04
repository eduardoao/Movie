using System;
using System.ComponentModel.DataAnnotations;

namespace Movie.Web.Tags;

public class CreateTagRequest
{
  public const string Route = "/Tags";

  [Required]
  public string? Title { get; set; }

}
