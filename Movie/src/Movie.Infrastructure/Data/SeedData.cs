using Movie.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore;
using Movie.Core._2_MovieAggregate;
using Movie.Core._1_ContributorAggregate;

namespace Movie.Infrastructure.Data;

public static class SeedData
{
  public static readonly Contributor Contributor1 = new("Eduardo");
  public static readonly Contributor Contributor2 = new("Fabiana");
  public static readonly Contributor Contributor3 = new("Alone");
  public static readonly Contributor Contributor4 = new("X-Men");

  public static readonly Tag Tag1 = new("madness");  
  public static readonly Tag Tag2 = new("1980s");





  public static async Task InitializeAsync(AppDbContext dbContext)
  {
    if (await dbContext.Contributors.AnyAsync()) return; // DB has been seeded

    await PopulateTestDataAsync(dbContext);
  }

  public static async Task PopulateTestDataAsync(AppDbContext dbContext)
  {
    dbContext.Contributors.AddRange([Contributor1, Contributor2, Contributor3]);
    Tag1.SetCreatedAt();
    Tag2.SetCreatedAt();
    dbContext.Tags.AddRange([Tag1, Tag2]);
    await dbContext.SaveChangesAsync();
  }


 
}
