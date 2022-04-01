using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Data.Migrations
{
    public partial class AzureMigrationMarch31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampusID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_CampusID",
                table: "Course",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ProfID",
                table: "Course",
                column: "ProfID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Campus_CampusID",
                table: "Course",
                column: "CampusID",
                principalTable: "Campus",
                principalColumn: "CampusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Prof_ProfID",
                table: "Course",
                column: "ProfID",
                principalTable: "Prof",
                principalColumn: "ProfID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
