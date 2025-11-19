using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oid85.Documents.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnModeToDocumentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentEntities_DocumentCategoryEntities_CategoryId",
                schema: "public",
                table: "DocumentEntities");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                schema: "public",
                table: "DocumentEntities",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mode",
                schema: "public",
                table: "DocumentEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentEntities_DocumentCategoryEntities_CategoryId",
                schema: "public",
                table: "DocumentEntities",
                column: "CategoryId",
                principalSchema: "public",
                principalTable: "DocumentCategoryEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentEntities_DocumentCategoryEntities_CategoryId",
                schema: "public",
                table: "DocumentEntities");

            migrationBuilder.DropColumn(
                name: "Mode",
                schema: "public",
                table: "DocumentEntities");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                schema: "public",
                table: "DocumentEntities",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentEntities_DocumentCategoryEntities_CategoryId",
                schema: "public",
                table: "DocumentEntities",
                column: "CategoryId",
                principalSchema: "public",
                principalTable: "DocumentCategoryEntities",
                principalColumn: "Id");
        }
    }
}
