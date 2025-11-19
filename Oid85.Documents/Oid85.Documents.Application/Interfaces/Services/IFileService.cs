using Microsoft.AspNetCore.Http;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Interfaces.Services
{
    /// <summary>
    /// Сервис файлов
    /// </summary>
    public interface IFileService
    {
        Task<UploadDocumentFileResponse?> UploadDocumentFileAsync(IFormFile file);
    }
}
