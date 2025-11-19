using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Oid85.Documents.Infrastructure.Entities.Base;

namespace Oid85.Documents.Infrastructure.Entities
{
    /// <summary>
    /// Документ
    /// </summary>
    public class DocumentEntity : AuditableEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [MaxLength(500)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// ФИО
        /// </summary>
        [MaxLength(500)]
        public string? Fio { get; set; }

        /// <summary>
        /// Серия
        /// </summary>
        [MaxLength(500)]
        public string? Series { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        [MaxLength(500)]
        public string? Number { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        [MaxLength(500)]
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
        [Column(TypeName = "decimal(10,1)")]
        public decimal? Sum { get; set; }

        /// <summary>
        /// Флаг актуальности документа
        /// </summary>
        public bool? IsActual { get; set; }

        /// <summary>
        /// Режим документа (хранение/загрузка)
        /// </summary>
        public string? Mode { get; set; }

        /// <summary>
        /// Категория документа
        /// </summary>
        public DocumentCategoryEntity Category { get; set; }

        /// <summary>
        /// Список файлов
        /// </summary>
        public ICollection<DocumentFileEntity>? Files { get; set; }
    }
}
