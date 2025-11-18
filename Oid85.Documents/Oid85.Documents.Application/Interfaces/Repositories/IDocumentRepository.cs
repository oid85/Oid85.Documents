using Oid85.Documents.Core.Models;

namespace Oid85.Documents.Application.Interfaces.Repositories
{
    /// <summary>
    /// Репозиторий документов
    /// </summary>
    public interface IDocumentRepository
    {
        /// <summary>
        /// Создать документ
        /// </summary>
        Task<Guid?> CreateDocumentAsync(Document model, Guid documentCategoryId);
    }
}
