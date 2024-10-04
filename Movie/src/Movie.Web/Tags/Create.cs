using FastEndpoints;
using MediatR;
using Movie.UseCases.Tags.Create;
using Movie.Web.Contributors;

namespace Movie.Web.Tags;

public class Create(IMediator _mediator): Endpoint<CreateTagRequest, CreateTagResponse>
{
    public override void Configure()
  {
    Post(CreateTagRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      // XML Docs are used by default but are overridden by these properties:
      //s.Summary = "Create a new tag.";
      //s.Description = "Create a new tag. A valid name is required.";
      s.ExampleRequest = new CreateTagRequest { Title = "Tag Name" };
    });
  }


 public override async Task HandleAsync(
    CreateTagRequest request,
    CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new CreateTagCommand(request.Title!, cancellationToken));

    if (result.IsSuccess)
    {
      Response = new CreateTagResponse(result.Value, request.Title!);
      return;
    }    
  }
}
