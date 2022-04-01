using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Data.Migrations
{
    public partial class UniversityStudentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampusID",
                table: "universityStudents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MajorID",
                table: "universityStudents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    CampusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CampusLocation = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CampusCapacity = table.Column<int>(type: "int", nullable: false),
                    NumberOfProfs = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.CampusID);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CourseCampus = table.Column<int>(type: "int", nullable: false),
                    CourseProf = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    MajorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NumberOfProfs = table.Column<int>(type: "int", nullable: false),
                    MajorCapacity = table.Column<int>(type: "int", nullable: false),
                    OfficeLocation = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.MajorID);
                });

            migrationBuilder.CreateTable(
                name: "Prof",
                columns: table => new
                {
                    ProfID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfCampus = table.Column<int>(type: "int", nullable: false),
                    ProfName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProfAge = table.Column<int>(type: "int", nullable: false),
                    ProfMajor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prof", x => x.ProfID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_universityStudents_CampusID",
                table: "universityStudents",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_universityStudents_MajorID",
                table: "universityStudents",
                column: "MajorID");

            migrationBuilder.AddForeignKey(
                name: "FK_universityStudents_Campus_CampusID",
                table: "universityStudents",
                column: "CampusID",
                principalTable: "Campus",
                principalColumn: "CampusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_universityStudents_Major_MajorID",
                table: "universityStudents",
                column: "MajorID",
                principalTable: "Major",
                principalColumn: "MajorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_universityStudents_Campus_CampusID",
                table: "universityStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_universityStudents_Major_MajorID",
                table: "universityStudents");

            migrationBuilder.DropTable(
                name: "Campus");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "Prof");

            migrationBuilder.DropIndex(
                name: "IX_universityStudents_CampusID",
                table: "universityStudents");

            migrationBuilder.DropIndex(
                name: "IX_universityStudents_MajorID",
                table: "universityStudents");

            migrationBuilder.DropColumn(
                name: "CampusID",
                table: "universityStudents");

            migrationBuilder.DropColumn(
                name: "MajorID",
                table: "universityStudents");
        }
    }
}
