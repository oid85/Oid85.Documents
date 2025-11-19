using Microsoft.EntityFrameworkCore;
using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Common.KnownConstants;
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
        public async Task<Guid?> UploadDocumentFileAsync(DocumentFile model)
        {
            await using var context = await contextFactory.CreateDbContextAsync();

            var documentEntity = await context.DocumentEntities.FirstOrDefaultAsync(x => x.Mode == KnownDocumentModes.Upload);
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

            documentEntity.Mode = KnownDocumentModes.Store;
            
            await context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
