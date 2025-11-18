using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core.Models;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Services
{
    /// <inheritdoc />
    internal class CategoryService(
        ICategoryRepository categoryRepository) : ICategoryService
    {
        /// <inheritdoc />
        public async Task<CreateDocumentCategoryResponse?> CreateDocumentCategoryAsync(CreateDocumentCategoryRequest request)
        {
            var model = new DocumentCategory
            {
                Name = request.Name
            };

            var id = await categoryRepository.CreateDocumentCategoryAsync(model);

            if (id is null)
                return null;

            var response = new CreateDocumentCategoryResponse
            {
                Id = id.Value
            };

            return response;
        }

        /// <inheritdoc />
        public async Task<GetDocumentCategoryListResponse?> GetDocumentCategoryListAsync(GetDocumentCategoryListRequest request)
        {
            var models = await categoryRepository.GetDocumentCategoryListAsync();

            if (models is null)
                return null;

            var response = new GetDocumentCategoryListResponse
            {
                DocumentCategories = models
                .Select(x => new GetDocumentCategoryListItemResponse
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToList()
            };

            return response;
        }
    }
}
