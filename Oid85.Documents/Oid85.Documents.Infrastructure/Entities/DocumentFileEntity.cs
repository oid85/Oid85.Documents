using System.ComponentModel.DataAnnotations;
using Oid85.Documents.Infrastructure.Entities.Base;

namespace Oid85.Documents.Infrastructure.Entities
{
    /// <summary>
    /// Файл документа
    /// </summary>
    public class DocumentFileEntity : AuditableEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [MaxLength(500)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Тип
        /// </summary>
        [MaxLength(500)]
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
        public DocumentEntity Document { get; set; }
    }
}
