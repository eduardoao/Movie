using System;
using Microsoft.EntityFrameworkCore;
using Movie.UseCases.Tags;
using Movie.UseCases.Tags.List;

namespace Movie.Infrastructure.Data.Queries;

public class ListTagsQueryService(AppDbContext _db) : IListTagsQueryService
{
  public async Task<IEnumerable<TagDTO>> ListAsync()
  {
    // NOTE: This will fail if testing with EF InMemory provider!
    var result = await _db.Database.SqlQuery<TagDTO>(
      $"SELECT Id, Title, Enabled, CreatedAt FROM Tags") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
