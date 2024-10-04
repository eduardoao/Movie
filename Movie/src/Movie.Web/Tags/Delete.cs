using Ardalis.Result;
using Movie.UseCases.Contributors.Delete;
using FastEndpoints;
using MediatR;

namespace Movie.Web.Tags;

/// <summary>
/// Delete a Contributor.
/// </summary>
/// <remarks>
/// Delete a Contributor by providing a valid integer id.
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
    var command = new DeleteContributorCommand(request.TagId);

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
