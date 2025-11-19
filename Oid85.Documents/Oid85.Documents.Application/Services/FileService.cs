using Microsoft.AspNetCore.Http;
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
        public async Task<UploadDocumentFileResponse?> UploadDocumentFileAsync(IFormFile file)
        {
            using var ms = new MemoryStream();
            await file.CopyToAsync(ms);
            var bytes = ms.ToArray();

            var model = new DocumentFile
            {
                Name = file.FileName,
                ContentType = file.ContentType,
                Size = file.Length,
                Content = bytes                
            };

            var id = await fileRepository.UploadDocumentFileAsync(model);

            if (id is null)
                return null;

            var response = new UploadDocumentFileResponse
            {
                Id = id.Value
            };

            return response;
        }
    }
}
