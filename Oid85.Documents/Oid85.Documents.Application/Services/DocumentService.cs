using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core.Models;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Services
{
    /// <inheritdoc />
    internal class DocumentService(
        IDocumentRepository documentRepository) : IDocumentService
    {
        /// <inheritdoc />
        public async Task<CreateDocumentResponse?> CreateDocumentAsync(CreateDocumentRequest request)
        {
            var model = new Document
            {
                Name = request.Name,
                Fio = request.Fio,
                Series = request.Series,
                Number = request.Number,
                Issue = request.Issue,
                Date = request.Date,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Sum = request.Sum,
                IsActual = request.IsActual
            };

            var id = await documentRepository.CreateDocumentAsync(model, request.DocumentCategoryId);

            if (id is null)
                return null;

            var response = new CreateDocumentResponse
            {
                Id = id.Value
            };

            return response;
        }

        /// <inheritdoc />
        public async Task<GetDocumentListResponse?> GetDocumentListAsync(GetDocumentListRequest request)
        {
            var models = await documentRepository.GetDocumentListAsync(request.DocumentCategoryId);

            if (models is null)
                return null;

            var response = new GetDocumentListResponse
            {
                Documents = models
                .Select(x => new GetDocumentListItemResponse
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
