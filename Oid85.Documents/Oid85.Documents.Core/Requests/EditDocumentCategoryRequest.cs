namespace Oid85.Documents.Core.Requests
{
    /// <summary>
    /// Редактировать категорию
    /// </summary>
    public class EditDocumentCategoryRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
    }
}
