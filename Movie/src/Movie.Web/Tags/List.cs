using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Movie.UseCases.Tags;
using Movie.UseCases.Tags.List;

namespace Movie.Web.Tags;

/// <summary>
/// List all Contributors
/// </summary>
/// <remarks>
/// List all contributors - returns a ContributorListResponse containing the Contributors.
/// </remarks>
public class List(IMediator _mediator) : EndpointWithoutRequest<TagListResponse>
{
  public override void Configure()
  {
    Get("/Tags");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    Result<IEnumerable<TagDTO>> result = await _mediator.Send(new ListTagsQuery(null, null), cancellationToken);

    if (result.IsSuccess)
    {
      Response = new TagListResponse
      {
        Tags = result.Value.Select(t => new TagRecord(t.Id, t.Title)).ToList()
      };
    }
  }
}
