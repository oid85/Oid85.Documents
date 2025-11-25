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
[Route("api/document-categories")]
[ApiController]
public class DocumentCategoriesController(
    IDocumentCategoryService categoryService)
    : BaseController
{
    /// <summary>
    /// Получить список категорий
    /// </summary>
    [HttpPost("list")]
    [ProducesResponseType(typeof(BaseResponse<GetDocumentCategoryListResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<GetDocumentCategoryListResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<GetDocumentCategoryListResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> GetDocumentCategoryListAsync(
        [FromBody] GetDocumentCategoryListRequest request) =>
        GetResponseAsync(
            () => categoryService.GetDocumentCategoryListAsync(request),
            result => new BaseResponse<GetDocumentCategoryListResponse> { Result = result });

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

    /// <summary>
    /// Редактировать категорию
    /// </summary>
    [HttpPost("edit")]
    [ProducesResponseType(typeof(BaseResponse<EditDocumentCategoryResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<EditDocumentCategoryResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<EditDocumentCategoryResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> EditDocumentCategoryAsync(
        [FromBody] EditDocumentCategoryRequest request) =>
        GetResponseAsync(
            () => categoryService.EditDocumentCategoryAsync(request),
            result => new BaseResponse<EditDocumentCategoryResponse> { Result = result });

    /// <summary>
    /// Удалить категорию
    /// </summary>
    [HttpPost("delete")]
    [ProducesResponseType(typeof(BaseResponse<DeleteDocumentCategoryResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<DeleteDocumentCategoryResponse>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(BaseResponse<DeleteDocumentCategoryResponse>), StatusCodes.Status500InternalServerError)]
    public Task<IActionResult> DeleteDocumentCategoryAsync(
        [FromBody] DeleteDocumentCategoryRequest request) =>
        GetResponseAsync(
            () => categoryService.DeleteDocumentCategoryAsync(request),
            result => new BaseResponse<DeleteDocumentCategoryResponse> { Result = result });
}