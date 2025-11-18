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

        /// <inheritdoc />
        public async Task<List<DocumentCategory>?> GetDocumentCategoryListAsync()
        {
            await using var context = await contextFactory.CreateDbContextAsync();

            var entities = await context.DocumentCategoryEntities
                .Where(x => !x.IsDeleted)
                .ToListAsync();

            if (entities is null)
                return null;

            var models = entities
                .Select(x =>
                new DocumentCategory
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,
                    DeletedAt = x.DeletedAt,
                    IsDeleted = x.IsDeleted
                })
                .ToList();

            return models;
        }
    }
}
