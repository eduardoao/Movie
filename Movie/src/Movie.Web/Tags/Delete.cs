using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Movie.UseCases.Tags.Delete;

namespace Movie.Web.Tags;

/// <summary>
/// Delete a Tag.
/// </summary>
/// <remarks>
/// Delete a Tag by providing a valid integer id.
/// </remarks>
public class Delete(IMediator _mediator)
  : Endpoint<DeleteTagRequest>
{
  public override void Configure()
  {
    Delete(DeleteTagRequest.Route);
    AllowAnonymous();
  }

  public override async Task HandleAsync(
    DeleteTagRequest request,
    CancellationToken cancellationToken)
  {
    var command = new DeleteTagCommand(request.TagId);

    var result = await _mediator.Send(command, cancellationToken);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      await SendNoContentAsync(cancellationToken);
    };
    // TODO: Handle other issues as needed
  }
}
