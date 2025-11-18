using Microsoft.EntityFrameworkCore;
using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Core.Models;
using Oid85.Documents.Infrastructure.Entities;

namespace Oid85.Documents.Infrastructure.Repositories
{
    /// <inheritdoc />
    public class CategoryRepository(
        IDbContextFactory<DocumentsContext> contextFactory
        ) : ICategoryRepository
    {
        /// <inheritdoc />
        public async Task<Guid?> CreateDocumentCategoryAsync(DocumentCategory model)
        {
            await using var context = await contextFactory.CreateDbContextAsync();

            var entity = new DocumentCategoryEntity
            {
                Id = Guid.NewGuid(),
                Name = model.Name
            };

            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
