using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Interfaces.Services
{
    /// <summary>
    /// Сервис документов
    /// </summary>
    public interface IDocumentService
    {
        Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request);
    }
}
