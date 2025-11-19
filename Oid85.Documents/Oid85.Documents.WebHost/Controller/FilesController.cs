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
    [HttpPost("upload")]
    [ProducesResponseType(typeof(BaseResponse<UploadDocumentFileResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<UploadDocumentFileResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<UploadDocumentFileResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> UploadFileAsync(IFormFile file) => 
        GetResponseAsync(
            () => fileService.UploadDocumentFileAsync(file),
            result => new BaseResponse<UploadDocumentFileResponse> { Result = result });
}