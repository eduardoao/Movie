using Ardalis.Result;

namespace Movie.Core.Interfaces;

public interface IDeleteTagService
{
  public Task<Result> DeleteTagService(int tagId);

}
