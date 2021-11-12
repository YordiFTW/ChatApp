using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApp.API.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserCount",
                table: "Chats",
                newName: "ChatType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChatType",
                table: "Chats",
                newName: "UserCount");
        }
    }
}
