using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Services
{
    /// <inheritdoc />
    internal class CategoryService : ICategoryService
    {
        /// <inheritdoc />
        public Task<CreateDocumentCategoryResponse> CreateDocumentCategoryAsync(CreateDocumentCategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
