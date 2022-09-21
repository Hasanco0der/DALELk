using Microsoft.EntityFrameworkCore.Migrations;

namespace DALELk.Migrations
{
    public partial class updateinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Categorys_Categorysid",
                table: "Categorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Doctors_Doctorid",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_Doctorid",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_Categorysid",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Doctorid",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Categoryid",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Categorysid",
                table: "Categorys");

            migrationBuilder.AddColumn<int>(
                name: "Categoryid",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Categoryid",
                table: "Doctors",
                column: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Categorys_Categoryid",
                table: "Doctors",
                column: "Categoryid",
                principalTable: "Categorys",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Categorys_Categoryid",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_Categoryid",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Categoryid",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "Doctorid",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Categoryid",
                table: "Categorys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Categorysid",
                table: "Categorys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_Doctorid",
                table: "Doctors",
                column: "Doctorid");

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_Categorysid",
                table: "Categorys",
                column: "Categorysid");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Categorys_Categorysid",
                table: "Categorys",
                column: "Categorysid",
                principalTable: "Categorys",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Doctors_Doctorid",
                table: "Doctors",
                column: "Doctorid",
                principalTable: "Doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
