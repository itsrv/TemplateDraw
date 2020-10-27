using Microsoft.EntityFrameworkCore.Migrations;

namespace FormSubmit.Migrations
{
    public partial class LayoutDetailsAddedToFormData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LayoutColumn",
                table: "FormData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LayoutId",
                table: "FormData",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LayoutType",
                table: "FormData",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LayoutColumn",
                table: "FormData");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "FormData");

            migrationBuilder.DropColumn(
                name: "LayoutType",
                table: "FormData");
        }
    }
}
