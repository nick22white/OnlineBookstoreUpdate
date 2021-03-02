using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookstore.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Books",
                newName: "Classification");

            migrationBuilder.AddColumn<string>(
                name: "AuthFirstName",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AuthLastName",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthFirstName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AuthLastName",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Classification",
                table: "Books",
                newName: "Author");
        }
    }
}
