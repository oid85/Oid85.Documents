namespace Oid85.Documents.Core.Requests
{
    /// <summary>
    /// Запрос на создание файла документа
    /// </summary>
    public class CreateDocumentFileRequest
    {
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Размер файла
        /// </summary>        
        public long Size { get; set; }

        /// <summary>
        /// Содержимое файла
        /// </summary>        
        public byte[] Content { get; set; }
    }
}
