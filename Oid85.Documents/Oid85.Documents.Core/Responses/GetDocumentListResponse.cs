namespace Oid85.Documents.Core.Responses
{
    public class GetDocumentListResponse
    {
        public List<GetDocumentListItemResponse> Documents { get; set; }
    }

    public class GetDocumentListItemResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
