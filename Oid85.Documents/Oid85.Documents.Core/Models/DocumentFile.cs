using Oid85.Documents.Core.Models.Base;

namespace Oid85.Documents.Core.Models
{
    /// <summary>
    /// Файл документа
    /// </summary>
    public class DocumentFile : AuditableModel
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Тип
        /// </summary>
        public string ContentType { get; set; } = string.Empty;

        /// <summary>
        /// Размер файла
        /// </summary>        
        public long Size { get; set; }

        /// <summary>
        /// Содержимое файла
        /// </summary>        
        public byte[]? Content { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public Document Document { get; set; }
    }
}
