using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Movie.UseCases.Tags.Get;
using Movie.UseCases.Tags.Update;

namespace Movie.Web.Tags;

/// <summary>
/// Update an existing Contributor.
/// </summary>
/// <remarks>
/// Update an existing Contributor by providing a fully defined replacement set of values.
/// See: https://stackoverflow.com/questions/60761955/rest-update-best-practice-put-collection-id-without-id-in-body-vs-put-collecti
/// </remarks>
public class Update(IMediator _mediator): Endpoint<UpdateTagRequest, UpdateTagResponse>
{
  public override void Configure()
  {
    Put(UpdateTagRequest.Route);
    AllowAnonymous();
  }

  public override async Task HandleAsync(
    UpdateTagRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new UpdateTagCommand(request.Id, request.Title!), cancellationToken);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    var query = new GetTagQuery(request.TagId);

    var queryResult = await _mediator.Send(query, cancellationToken);

    if (queryResult.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (queryResult.IsSuccess)
    {
      var dto = queryResult.Value;
      Response = new UpdateTagResponse(new TagRecord(dto.Id, dto.Title));
      return;
    }
  }
}
