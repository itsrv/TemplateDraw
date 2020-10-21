using Microsoft.EntityFrameworkCore.Migrations;

namespace FormSubmit.Migrations
{
    public partial class AddDetailGroupIdToSubmitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DetailGroup",
                table: "SubmitData",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailGroup",
                table: "SubmitData");
        }
    }
}
