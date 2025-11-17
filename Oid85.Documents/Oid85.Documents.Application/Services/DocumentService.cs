using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Services
{
    /// <inheritdoc />
    internal class DocumentService : IDocumentService
    {
        /// <inheritdoc />
        public Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
