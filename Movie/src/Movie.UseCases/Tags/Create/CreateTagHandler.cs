using System;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Movie.Core._2_MovieAggregate;

namespace Movie.UseCases.Tags.Create;

public class CreateTagHandler(IRepository<Tag> _repository)
  : ICommandHandler<CreateTagCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateTagCommand request, CancellationToken cancellationToken)
  {
    var newTag = new Tag(request.Title);
    
    newTag.SetCreatedAt();

    var createdTag = await _repository.AddAsync(newTag, cancellationToken);

    return createdTag.Id;
  }
}
