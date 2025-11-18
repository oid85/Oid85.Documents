using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oid85.Documents.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "DocumentEntities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "DocumentFileEntities",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "DocumentEntities",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "DocumentCategoryEntities",
                newName: "id");
        }
    }
}
