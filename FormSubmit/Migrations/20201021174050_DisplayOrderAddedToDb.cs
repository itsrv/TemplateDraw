using Microsoft.EntityFrameworkCore.Migrations;

namespace FormSubmit.Migrations
{
    public partial class DisplayOrderAddedToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "FormData",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "FormData");
        }
    }
}
