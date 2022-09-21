using Microsoft.EntityFrameworkCore.Migrations;

namespace DALELk.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoryid = table.Column<int>(type: "int", nullable: false),
                    Categorysid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categorys_Categorys_Categorysid",
                        column: x => x.Categorysid,
                        principalTable: "Categorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShahadaDec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Workhoure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressAsas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressJanbi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Doctors_Doctors_Doctorid",
                        column: x => x.Doctorid,
                        principalTable: "Doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_Categorysid",
                table: "Categorys",
                column: "Categorysid");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Doctorid",
                table: "Doctors",
                column: "Doctorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
