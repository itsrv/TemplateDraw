using Microsoft.EntityFrameworkCore.Migrations;

namespace FormSubmit.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormDetail",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FormData",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InputId = table.Column<string>(nullable: true),
                    value = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    InputLabel = table.Column<string>(nullable: true),
                    InputName = table.Column<string>(nullable: true),
                    FormId = table.Column<long>(nullable: false),
                    FormDetailid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormData_FormDetail_FormDetailid",
                        column: x => x.FormDetailid,
                        principalTable: "FormDetail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormData_FormDetailid",
                table: "FormData",
                column: "FormDetailid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormData");

            migrationBuilder.DropTable(
                name: "FormDetail");
        }
    }
}
