using Microsoft.AspNetCore.Mvc;
using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;
using Oid85.Documents.WebHost.Controller.Base;

namespace Oid85.Documents.WebHost.Controller;

/// <summary>
/// Документы
/// </summary>
[Route("api/documents")]
[ApiController]
public class DocumentsController(
    IDocumentService documentService)
    : BaseController
{
    /// <summary>
    /// Получить список документов
    /// </summary>
    [HttpPost("list")]
    [ProducesResponseType(typeof(BaseResponse<GetDocumentListResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<GetDocumentListResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<GetDocumentListResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> GetDocumentListAsync(
        [FromBody] GetDocumentListRequest request) =>
        GetResponseAsync(
            () => documentService.GetDocumentListAsync(request),
            result => new BaseResponse<GetDocumentListResponse> { Result = result });

    /// <summary>
    /// Добавить документ
    /// </summary>
    [HttpPost("create")]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> CreateDocumentAsync(
        [FromBody] CreateDocumentRequest request) =>
        GetResponseAsync(
            () => documentService.CreateDocumentAsync(request),
            result => new BaseResponse<CreateDocumentResponse> { Result = result });
}