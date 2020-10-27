using Microsoft.EntityFrameworkCore.Migrations;

namespace FormSubmit.Migrations
{
    public partial class guidAddedtoformdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormData_FormDetail_FormDetailid",
                table: "FormData");

            migrationBuilder.DropIndex(
                name: "IX_FormData_FormDetailid",
                table: "FormData");

            migrationBuilder.DropColumn(
                name: "FormDetailid",
                table: "FormData");

            migrationBuilder.AddColumn<string>(
                name: "guid",
                table: "FormData",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "guid",
                table: "FormData");

            migrationBuilder.AddColumn<long>(
                name: "FormDetailid",
                table: "FormData",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormData_FormDetailid",
                table: "FormData",
                column: "FormDetailid");

            migrationBuilder.AddForeignKey(
                name: "FK_FormData_FormDetail_FormDetailid",
                table: "FormData",
                column: "FormDetailid",
                principalTable: "FormDetail",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
