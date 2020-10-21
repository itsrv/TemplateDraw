using Microsoft.EntityFrameworkCore.Migrations;

namespace FormSubmit.Migrations
{
    public partial class PostionDetailAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "FormData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionX",
                table: "FormData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionY",
                table: "FormData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Width",
                table: "FormData",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "FormData");

            migrationBuilder.DropColumn(
                name: "PositionX",
                table: "FormData");

            migrationBuilder.DropColumn(
                name: "PositionY",
                table: "FormData");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "FormData");
        }
    }
}
