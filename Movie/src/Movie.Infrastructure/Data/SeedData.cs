using Movie.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore;

namespace Movie.Infrastructure.Data;

public static class SeedData
{
  public static readonly Contributor Contributor1 = new("Eduardo");
  public static readonly Contributor Contributor2 = new("Fabiana");
  public static readonly Contributor Contributor3 = new("Alone");


  public static async Task InitializeAsync(AppDbContext dbContext)
  {
    if (await dbContext.Contributors.AnyAsync()) return; // DB has been seeded

    await PopulateTestDataAsync(dbContext);
  }

  public static async Task PopulateTestDataAsync(AppDbContext dbContext)
  {
    dbContext.Contributors.AddRange([Contributor1, Contributor2, Contributor3]);
    await dbContext.SaveChangesAsync();
  }
}
