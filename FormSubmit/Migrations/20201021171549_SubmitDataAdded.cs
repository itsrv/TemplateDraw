using Microsoft.EntityFrameworkCore.Migrations;

namespace FormSubmit.Migrations
{
    public partial class SubmitDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubmitData",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElmId = table.Column<long>(nullable: false),
                    value = table.Column<string>(nullable: false),
                    FormId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmitData", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubmitData");
        }
    }
}
