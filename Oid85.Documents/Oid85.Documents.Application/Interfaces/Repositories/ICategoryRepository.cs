using Oid85.Documents.Core.Models;

namespace Oid85.Documents.Application.Interfaces.Repositories
{
    /// <summary>
    /// Репозиторий категорий
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Создать документ
        /// </summary>
        Task<Guid?> CreateDocumentCategoryAsync(DocumentCategory model);
    }
}
