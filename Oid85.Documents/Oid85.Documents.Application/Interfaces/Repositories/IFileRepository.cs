using Oid85.Documents.Core.Models;

namespace Oid85.Documents.Application.Interfaces.Repositories
{
    /// <summary>
    /// Репозиторий файлов
    /// </summary>
    public interface IFileRepository
    {
        /// <summary>
        /// Создать документ
        /// </summary>
        Task<Guid?> CreateDocumentFileAsync(DocumentFile model, Guid documentId);
    }
}
