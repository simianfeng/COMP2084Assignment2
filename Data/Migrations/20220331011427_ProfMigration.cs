using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Data.Migrations
{
    public partial class ProfMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampusID",
                table: "Prof",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MajorID",
                table: "Prof",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prof_CampusID",
                table: "Prof",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_Prof_MajorID",
                table: "Prof",
                column: "MajorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prof_Campus_CampusID",
                table: "Prof",
                column: "CampusID",
                principalTable: "Campus",
                principalColumn: "CampusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prof_Major_MajorID",
                table: "Prof",
                column: "MajorID",
                principalTable: "Major",
                principalColumn: "MajorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prof_Campus_CampusID",
                table: "Prof");

            migrationBuilder.DropForeignKey(
                name: "FK_Prof_Major_MajorID",
                table: "Prof");

            migrationBuilder.DropIndex(
                name: "IX_Prof_CampusID",
                table: "Prof");

            migrationBuilder.DropIndex(
                name: "IX_Prof_MajorID",
                table: "Prof");

            migrationBuilder.DropColumn(
                name: "CampusID",
                table: "Prof");

            migrationBuilder.DropColumn(
                name: "MajorID",
                table: "Prof");
        }
    }
}
