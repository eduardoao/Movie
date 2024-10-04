using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Movie.UseCases.Tags.Get;
using Movie.Web.Contributors;

namespace Movie.Web.Tags;

/// <summary>
/// Get a Contributor by integer ID.
/// </summary>
/// <remarks>
/// Takes a positive integer ID and returns a matching Contributor record.
/// </remarks>
public class GetById(IMediator _mediator) : Endpoint<GetTagByIdRequest, TagRecord>
{
  public override void Configure()
  {
    Get(GetTagByIdRequest.Route);
    AllowAnonymous();
  }

  public override async Task HandleAsync(GetTagByIdRequest request,
    CancellationToken cancellationToken)
  {
    var query = new GetTagQuery(request.TagId);

    var result = await _mediator.Send(query, cancellationToken);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      Response = new TagRecord(result.Value.Id, result.Value.Title);
    }
  }
}
