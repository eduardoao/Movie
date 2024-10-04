using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Movie.Core.Interfaces;
using Movie.Core.Services;
using Movie.Infrastructure.Data;
using Movie.Infrastructure.Data.Queries;
using Movie.Infrastructure.Email;
using Movie.UseCases.Contributors.List;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Movie.Infrastructure;
public static class InfrastructureServiceExtensions
{
  public static IServiceCollection AddInfrastructureServices(
    this IServiceCollection services,
    ConfigurationManager config,
    ILogger logger)
  {
    string? connectionString = config.GetConnectionString("SqliteConnection");
    Guard.Against.Null(connectionString);
    services.AddDbContext<AppDbContext>(options =>
     options.UseSqlite(connectionString));

    services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
    services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
    services.AddScoped<IListContributorsQueryService, ListContributorsQueryService>();
    services.AddScoped<IDeleteContributorService, DeleteContributorService>();
    services.AddScoped<IDeleteTagService, DeleteTagService>();
    

    services.Configure<MailserverConfiguration>(config.GetSection("Mailserver"));

    logger.LogInformation("{Project} services registered", "Infrastructure");

    return services;
  }
}
