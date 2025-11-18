using Microsoft.AspNetCore.Mvc;
using Oid85.Documents.Application.Interfaces.Services;
using Oid85.Documents.Core;
using Oid85.Documents.Core.Requests;
using Oid85.Documents.Core.Responses;
using Oid85.Documents.WebHost.Controller.Base;

namespace Oid85.Documents.WebHost.Controller;

/// <summary>
/// Категории
/// </summary>
[Route("api/categories")]
[ApiController]
public class CategoriesController(
    ICategoryService categoryService)
    : BaseController
{
    /// <summary>
    /// Добавить категорию
    /// </summary>
    [HttpPost("create")]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentCategoryResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentCategoryResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<CreateDocumentCategoryResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> CreateDocumentCategoryAsync(
        [FromBody] CreateDocumentCategoryRequest request) =>
        GetResponseAsync(
            () => categoryService.CreateDocumentCategoryAsync(request),
            result => new BaseResponse<CreateDocumentCategoryResponse> { Result = result });
}