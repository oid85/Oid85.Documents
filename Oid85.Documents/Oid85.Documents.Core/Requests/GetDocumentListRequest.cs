namespace Oid85.Documents.Core.Requests
{
    /// <summary>
    /// Запрос на получение списка документов
    /// </summary>
    public class GetDocumentListRequest
    {
        public Guid DocumentCategoryId { get; set; }
    }
}
