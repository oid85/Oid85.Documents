using Oid85.Documents.Core.Models.Base;

namespace Oid85.Documents.Core.Models
{
    /// <summary>
    /// Категория документа
    /// </summary>
    public class DocumentCategory : AuditableModel
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Список документов
        /// </summary>
        public List<Document>? Documents { get; set; }
    }
}
