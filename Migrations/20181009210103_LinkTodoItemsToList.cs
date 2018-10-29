using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoretodo.Migrations
{
    public partial class LinkTodoItemsToList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_TodoLists_TodoListid",
                table: "TodoItem");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TodoLists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TodoItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TodoListid",
                table: "TodoItem",
                newName: "ListId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItem_TodoListid",
                table: "TodoItem",
                newName: "IX_TodoItem_ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_TodoLists_ListId",
                table: "TodoItem",
                column: "ListId",
                principalTable: "TodoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItem_TodoLists_ListId",
                table: "TodoItem");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TodoLists",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TodoItem",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ListId",
                table: "TodoItem",
                newName: "TodoListid");

            migrationBuilder.RenameIndex(
                name: "IX_TodoItem_ListId",
                table: "TodoItem",
                newName: "IX_TodoItem_TodoListid");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItem_TodoLists_TodoListid",
                table: "TodoItem",
                column: "TodoListid",
                principalTable: "TodoLists",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
