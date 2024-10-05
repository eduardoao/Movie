using Microsoft.Extensions.Logging;
using Movie.Core.Interfaces;
using MediatR;
using Movie.Core._2_MovieAggregate.Events;

namespace Movie.Core._2_MovieAggregate.Handlers;

internal class TagDeletedHandler (ILogger<TagDeletedHandler> logger,
  IEmailSender emailSender) : INotificationHandler<TagDeletedEvent>
{

   public async Task Handle(TagDeletedEvent domainEvent, CancellationToken cancellationToken)
   {

     logger.LogInformation("Handling Tag Deleted event for {tagId}", domainEvent.TagId);

    await emailSender.SendEmailAsync("eoalcantara@gmail.com",
                                     "eoalcantara@gmail.com",
                                     "Tag Deleted",
                                     $"Tag with id {domainEvent.TagId} was deleted.");

   }
  

}
