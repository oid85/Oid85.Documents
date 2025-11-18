namespace Oid85.Documents.Core.Requests
{
    /// <summary>
    /// Запрос на создание документа
    /// </summary>
    public class CreateDocumentRequest
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public Guid DocumentCategoryId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

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
        public bool? IsActual { get; set; }
    }
}
