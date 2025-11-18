using Microsoft.EntityFrameworkCore;
using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Core.Models;
using Oid85.Documents.Infrastructure.Entities;

namespace Oid85.Documents.Infrastructure.Repositories
{
    /// <inheritdoc />
    public class DocumentRepository(
        IDbContextFactory<DocumentsContext> contextFactory
        ) : IDocumentRepository
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
                Category = documentCategoryEntity
            };

            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }
    }
}
