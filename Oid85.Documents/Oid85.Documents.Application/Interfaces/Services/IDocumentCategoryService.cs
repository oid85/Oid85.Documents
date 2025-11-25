using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Interfaces.Services
{
    /// <summary>
    /// Сервис категорий
    /// </summary>
    public interface IDocumentCategoryService
    {
        /// <summary>
        /// Создать категорию
        /// </summary>
        Task<CreateDocumentCategoryResponse?> CreateDocumentCategoryAsync(CreateDocumentCategoryRequest request);
        
        /// <summary>
        /// Удалить категорию
        /// </summary>
        Task<DeleteDocumentCategoryResponse?> DeleteDocumentCategoryAsync(DeleteDocumentCategoryRequest request);
        
        /// <summary>
        /// Редактировать категорию
        /// </summary>
        Task<EditDocumentCategoryResponse?> EditDocumentCategoryAsync(EditDocumentCategoryRequest request);

        /// <summary>
        /// Получить список категорий
        /// </summary>
        Task<GetDocumentCategoryListResponse?> GetDocumentCategoryListAsync(GetDocumentCategoryListRequest request);
    }
}
