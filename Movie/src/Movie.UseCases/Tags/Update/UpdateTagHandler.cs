using Ardalis.Result;
using Ardalis.SharedKernel;
using Movie.Core._2_MovieAggregate;

namespace Movie.UseCases.Tags.Update;

public class UpdateTagHandler(IRepository<Tag> _repository): ICommandHandler<UpdateTagCommand, Result<TagDTO>>
{
  public async Task<Result<TagDTO>> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
  {
    var existingTag = await _repository.GetByIdAsync(request.TagId, cancellationToken);
    if (existingTag == null)
    {
      return Result.NotFound();
    }

    existingTag.UpdateName(request.NewTitle!);

    await _repository.UpdateAsync(existingTag, cancellationToken);

    return Result.Success(new TagDTO(existingTag.Id, existingTag.Title));
  }
}
