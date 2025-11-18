using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Services
{
    /// <inheritdoc />
    internal class FileService : IFileService
    {
        /// <inheritdoc />
        public Task<CreateDocumentFileResponse> CreateDocumentFileAsync(CreateDocumentFileRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
