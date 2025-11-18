using Oid85.Documents.Core.Models;

namespace Oid85.Documents.Application.Interfaces.Repositories
{
    /// <summary>
    /// Репозиторий категорий
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Создать категорию
        /// </summary>
        Task<Guid?> CreateDocumentCategoryAsync(DocumentCategory model);

        /// <summary>
        /// Получить список категорий
        /// </summary>
        Task<List<DocumentCategory>?> GetDocumentCategoryListAsync();
    }
}
