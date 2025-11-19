using Oid85.Documents.Core.Models.Base;

namespace Oid85.Documents.Core.Models
{
    /// <summary>
    /// Документ
    /// </summary>
    public class Document : AuditableModel
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// ФИО
        /// </summary>
        public string? Fio { get; set; }

        /// <summary>
        /// Серия
        /// </summary>
        public string? Series { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        public string? Issue { get; set; }

        /// <summary>
        /// Дата документа
        /// </summary>
        public DateOnly? Date { get; set; }

        /// <summary>
        /// Дата начала срока действия документа
        /// </summary>
        public DateOnly? StartDate { get; set; }

        /// <summary>
        /// Дата конца срока действия документа
        /// </summary>
        public DateOnly? EndDate { get; set; }

        /// <summary>
        /// Сумма документа
        /// </summary>
        public decimal? Sum { get; set; }

        /// <summary>
        /// Флаг актуальности документа
        /// </summary>
        public bool? IsActual { get; set; } = true;

        /// <summary>
        /// Режим документа (хранение/загрузка)
        /// </summary>
        public string? Mode { get; set; }

        /// <summary>
        /// Категория документа
        /// </summary>
        public DocumentCategory? Category { get; set; }

        /// <summary>
        /// Список файлов
        /// </summary>
        public ICollection<DocumentFile>? Files { get; set; }
    }
}
