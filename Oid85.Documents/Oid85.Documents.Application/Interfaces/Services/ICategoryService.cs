using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Interfaces.Services
{
    /// <summary>
    /// Сервис категорий
    /// </summary>
    public interface ICategoryService
    {
        Task<CreateDocumentCategoryResponse?> CreateDocumentCategoryAsync(CreateDocumentCategoryRequest request);
    }
}
