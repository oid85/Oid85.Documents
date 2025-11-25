using Oid85.Documents.Core.Models;

namespace Oid85.Documents.Application.Interfaces.Repositories
{
    /// <summary>
    /// Репозиторий категорий
    /// </summary>
    public interface IDocumentCategoryRepository
    {
        /// <summary>
        /// Создать категорию
        /// </summary>
        Task<Guid?> CreateDocumentCategoryAsync(DocumentCategory model);

        /// <summary>
        /// Удалить категорию
        /// </summary>
        Task<Guid?> DeleteDocumentCategoryAsync(Guid id);

        /// <summary>
        /// Редактировать категорию
        /// </summary>
        Task<Guid?> EditDocumentCategoryAsync(DocumentCategory model);

        /// <summary>
        /// Получить список категорий
        /// </summary>
        Task<List<DocumentCategory>?> GetDocumentCategoryListAsync();
    }
}
