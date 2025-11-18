namespace Oid85.Documents.Core.Requests
{
    /// <summary>
    /// Запрос на создание категории документа
    /// </summary>
    public class CreateDocumentCategoryRequest
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
    }
}
