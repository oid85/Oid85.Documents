using Microsoft.AspNetCore.Mvc;
using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;
using Oid85.Documents.WebHost.Controller.Base;

namespace Oid85.Documents.WebHost.Controller;

/// <summary>
/// Файлы
/// </summary>
[Route("api/files")]
[ApiController]
public class FilesController(
    IFileService fileService)
    : BaseController
{
    /// <summary>
    /// Добавить файл
    /// </summary>
    [HttpPost("create/{documentId}")]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentFileResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentFileResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentFileResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> CreateFileAsync(
        IFormFile file, Guid documentId) => 
        GetResponseAsync(
            () => fileService.CreateDocumentFileAsync(file, documentId),
            result => new BaseResponse<CreateDocumentFileResponse> { Result = result });
}