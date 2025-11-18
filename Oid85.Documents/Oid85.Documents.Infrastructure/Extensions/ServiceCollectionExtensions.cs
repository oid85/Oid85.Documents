using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Common.KnownConstants;
using Oid85.Documents.Infrastructure.Interceptors;
using Oid85.Documents.Infrastructure.Repositories;

namespace Oid85.Documents.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void ConfigureInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddSingleton<UpdateAuditableEntitiesInterceptor>();

        services.AddDbContextPool<DocumentsContext>((serviceProvider, options) =>
        {
            var updateInterceptor = serviceProvider.GetRequiredService<UpdateAuditableEntitiesInterceptor>();

            options
                .UseNpgsql(configuration.GetValue<string>(KnownSettingsKeys.PostgresDocumentsConnectionString)!)
                .AddInterceptors(updateInterceptor);
        });

        services.AddPooledDbContextFactory<DocumentsContext>(options =>
            options
                .UseNpgsql(configuration.GetValue<string>(KnownSettingsKeys.PostgresDocumentsConnectionString)!)
                .EnableServiceProviderCaching(false), poolSize: 32);

        services.AddTransient<IDocumentRepository, DocumentRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IFileRepository, FileRepository>();
    }

    public static async Task ApplyMigrations(this IHost host)
    {
        var scopeFactory = host.Services.GetRequiredService<IServiceScopeFactory>();
        await using var scope = scopeFactory.CreateAsyncScope();
        await using var context = scope.ServiceProvider.GetRequiredService<DocumentsContext>();
        await context.Database.MigrateAsync();
    }
}