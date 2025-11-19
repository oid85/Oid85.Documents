using Oid85.Documents.Core.Models;

namespace Oid85.Documents.Application.Interfaces.Repositories
{
    /// <summary>
    /// Репозиторий файлов
    /// </summary>
    public interface IFileRepository
    {
        /// <summary>
        /// Загрузить файл документа
        /// </summary>
        Task<Guid?> UploadDocumentFileAsync(DocumentFile model);
    }
}
