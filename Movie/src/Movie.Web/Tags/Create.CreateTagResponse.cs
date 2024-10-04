using System;

namespace Movie.Web.Tags;

public class CreateTagResponse(int id, string title)
{
  public int Id { get; set; } = id;
  public string Title { get; set; } = title;

}
