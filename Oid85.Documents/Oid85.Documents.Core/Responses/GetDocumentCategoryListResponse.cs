namespace Oid85.Documents.Core.Responses
{
    public class GetDocumentCategoryListResponse
    {
        public List<GetDocumentCategoryListItemResponse> DocumentCategories { get; set; }
    }

    public class GetDocumentCategoryListItemResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
