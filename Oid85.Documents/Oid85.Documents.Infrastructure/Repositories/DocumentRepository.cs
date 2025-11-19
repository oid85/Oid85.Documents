using Microsoft.EntityFrameworkCore;
using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Common.KnownConstants;
using Oid85.Documents.Core.Models;
using Oid85.Documents.Infrastructure.Entities;

namespace Oid85.Documents.Infrastructure.Repositories
{
    /// <inheritdoc />
    public class DocumentRepository(
        IDbContextFactory<DocumentsContext> contextFactory) 
        : IDocumentRepository
    {
        /// <inheritdoc />
        public async Task<Guid?> CreateDocumentAsync(Document model, Guid documentCategoryId)
        {
            await using var context = await contextFactory.CreateDbContextAsync();

            var documentCategoryEntity = await context.DocumentCategoryEntities.FirstOrDefaultAsync(x => x.Id == documentCategoryId);
            if (documentCategoryEntity is null) return null;

            var entity = new DocumentEntity
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Fio = model.Fio,
                Series = model.Series,
                Number = model.Number,
                Issue = model.Issue,
                Date = model.Date,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Sum = model.Sum,
                IsActual = model.IsActual,
                Mode = model.Mode,
                Category = documentCategoryEntity
            };

            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }

        /// <inheritdoc />
        public async Task<List<Document>?> GetDocumentListAsync(Guid documentCategoryId)
        {
            await using var context = await contextFactory.CreateDbContextAsync();

            var entities = await context.DocumentEntities
                .Include(x => x.Category)
                .Where(x => !x.IsDeleted)
                .Where(x => x.Category.Id == documentCategoryId)
                .ToListAsync();

            if (entities is null)
                return null;

            var models = entities
                .Select(x =>
                new Document
                {
                    Id = x.Id,
                    Name = x.Name,
                    Fio = x.Fio,
                    Series = x.Series,
                    Number = x.Number,
                    Issue = x.Issue,
                    Date = x.Date,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Sum = x.Sum,
                    IsActual = x.IsActual,
                    Mode = x.Mode,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,
                    DeletedAt = x.DeletedAt,
                    IsDeleted = x.IsDeleted                    
                })
                .ToList();

            return models;
        }

        /// <inheritdoc />
        public async Task<Guid?> SetDocumentUploadModeAsync(Guid documentId)
        {
            await using var context = await contextFactory.CreateDbContextAsync();

            await context.DocumentEntities
                .Where(x => x.Mode != KnownDocumentModes.Store)
                .ExecuteUpdateAsync(x => x
                        .SetProperty(entity => entity.Mode, KnownDocumentModes.Store));

            await context.DocumentEntities
                .Where(x => x.Id == documentId)
                .ExecuteUpdateAsync(x => x
                        .SetProperty(entity => entity.Mode, KnownDocumentModes.Upload));

            await context.SaveChangesAsync();

            return documentId;
        }
    }
}
