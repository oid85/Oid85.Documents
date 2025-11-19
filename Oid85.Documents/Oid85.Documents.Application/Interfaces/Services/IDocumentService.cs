using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;

namespace Oid85.Documents.Application.Interfaces.Services
{
    /// <summary>
    /// Сервис документов
    /// </summary>
    public interface IDocumentService
    {
        /// <summary>
        /// Создать документ
        /// </summary>
        Task<CreateDocumentResponse?> CreateDocumentAsync(CreateDocumentRequest request);

        /// <summary>
        /// Получить список документов
        /// </summary>
        Task<GetDocumentListResponse?> GetDocumentListAsync(GetDocumentListRequest request);

        /// <summary>
        /// Установить для документа режим загрузки файлов
        /// </summary>
        Task<SetDocumentUploadModeResponse?> SetDocumentUploadModeAsync(SetDocumentUploadModeRequest request);
    }
}
