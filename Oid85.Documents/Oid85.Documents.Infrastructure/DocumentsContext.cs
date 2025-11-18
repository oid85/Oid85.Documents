using Microsoft.EntityFrameworkCore;
using Oid85.Documents.Common.KnownConstants;
using Oid85.Documents.Infrastructure.Entities;
using Oid85.Documents.Infrastructure.Schemas;

namespace Oid85.Documents.Infrastructure;

public class DocumentsContext(DbContextOptions<DocumentsContext> options) : DbContext(options)
{
    public DbSet<DocumentEntity> DocumentEntities { get; set; }
    public DbSet<DocumentCategoryEntity> DocumentCategoryEntities { get; set; }
    public DbSet<DocumentFileEntity> DocumentFileEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .HasDefaultSchema(KnownDatabaseSchemas.Default)
            .ApplyConfigurationsFromAssembly(
                typeof(DocumentsContext).Assembly,
                type => type
                    .GetInterface(typeof(IDocumentsSchema).ToString()) != null)
            .UseIdentityAlwaysColumns();
    }    
}