using System.ComponentModel.DataAnnotations;
using Oid85.Documents.Infrastructure.Entities.Base;

namespace Oid85.Documents.Infrastructure.Entities
{
    /// <summary>
    /// Категория документа
    /// </summary>
    public class DocumentCategoryEntity : AuditableEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [MaxLength(500)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Список документов
        /// </summary>
        public ICollection<DocumentEntity>? Documents { get; set; }
    }
}
