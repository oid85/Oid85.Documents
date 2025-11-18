using Oid85.Documents.Application.Interfaces.Repositories;
using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core.Models;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Services
{
    /// <inheritdoc />
    internal class FileService(
        IFileRepository fileRepository) : IFileService
    {
        /// <inheritdoc />
        public async Task<CreateDocumentFileResponse?> CreateDocumentFileAsync(CreateDocumentFileRequest request)
        {
            var model = new DocumentFile
            {
                Name = request.Name,
                ContentType = request.ContentType,
                Size = request.Size,
                Content = request.Content
            };

            var id = await fileRepository.CreateDocumentFileAsync(model, request.DocumentId);

            if (id is null)
                return null;

            var response = new CreateDocumentFileResponse
            {
                Id = id.Value
            };

            return response;
        }
    }
}
