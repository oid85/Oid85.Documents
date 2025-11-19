namespace Oid85.Documents.Core.Requests
{
    /// <summary>
    /// Установить для документа режим загрузки файлов
    /// </summary>
    public class SetDocumentUploadModeRequest
    {
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public Guid Id { get; set; }
    }
}
