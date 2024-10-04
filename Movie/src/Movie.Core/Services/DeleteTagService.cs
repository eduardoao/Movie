using Ardalis.Result;
using Ardalis.SharedKernel;
using MediatR;
using Microsoft.Extensions.Logging;
using Movie.Core._2_MovieAggregate;
using Movie.Core._2_MovieAggregate.Events;
using Movie.Core.Interfaces;

namespace Movie.Core.Services;

public class DeleteTagService(IRepository<Tag> _repository,
  IMediator _mediator,
  ILogger<DeleteContributorService> _logger) : IDeleteTagService
{
  async Task<Result> IDeleteTagService.DeleteTagService(int tagId)
  {
    _logger.LogInformation("Deleting Tag {tagrId}", tagId);
    Tag? aggregateToDelete = await _repository.GetByIdAsync(tagId);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new TagDeletedEvent(tagId);
    await _mediator.Publish(domainEvent);
    return Result.Success();
  }
}
