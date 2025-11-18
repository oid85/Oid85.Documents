using Microsoft.EntityFrameworkCore;
using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Core.Models;
using Oid85.Documents.Infrastructure.Entities;

namespace Oid85.Documents.Infrastructure.Repositories
{
    /// <inheritdoc />
    public class FileRepository(
        IDbContextFactory<DocumentsContext> contextFactory
        ) : IFileRepository
    {
        /// <inheritdoc />
        public async Task<Guid?> CreateDocumentFileAsync(DocumentFile model, Guid documentId)
        {
            await using var context = await contextFactory.CreateDbContextAsync();

            var documentEntity = await context.DocumentEntities.FirstOrDefaultAsync(x => x.Id == documentId);
            if (documentEntity is null) return null;

            var entity = new DocumentFileEntity
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ContentType = model.ContentType,
                Size = model.Size,
                Content = model.Content,
                Document = documentEntity
            };

            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
