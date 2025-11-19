namespace Oid85.Documents.Core.Responses
{
    /// <summary>
    /// Установить для документа режим загрузки файлов
    /// </summary>
    public class SetDocumentUploadModeResponse
    {
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public Guid Id { get; set; }
    }
}
