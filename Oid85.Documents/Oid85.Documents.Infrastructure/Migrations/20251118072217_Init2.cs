using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oid85.Documents.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "DocumentEntities",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                schema: "public",
                table: "DocumentEntities",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                schema: "public",
                table: "DocumentEntities",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "DocumentEntities",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "DocumentEntities",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                schema: "public",
                table: "DocumentEntities",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "DocumentEntities",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "DocumentEntities",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "created_at");
        }
    }
}
