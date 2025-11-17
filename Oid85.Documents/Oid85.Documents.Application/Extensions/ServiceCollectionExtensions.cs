using Microsoft.Extensions.DependencyInjection;
using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Application.Services;

namespace Oid85.Documents.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void ConfigureApplicationServices(
        this IServiceCollection services)
    {
        services.AddTransient<IDocumentService, DocumentService>();
    }
}