using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Interfaces.Services
{
    /// <summary>
    /// Сервис категорий
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Создать категорию
        /// </summary>
        Task<CreateDocumentCategoryResponse?> CreateDocumentCategoryAsync(CreateDocumentCategoryRequest request);

        /// <summary>
        /// Получить список категорий
        /// </summary>
        Task<GetDocumentCategoryListResponse?> GetDocumentCategoryListAsync(GetDocumentCategoryListRequest request);
    }
}
