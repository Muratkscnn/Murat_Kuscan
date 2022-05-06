using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmanPresident = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.DepartmanId);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    PeriodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.PeriodId);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonCredit = table.Column<int>(type: "int", nullable: false),
                    PeriodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lessons_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "PeriodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmanId = table.Column<int>(type: "int", nullable: false),
                    StudentBirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentRegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Departmans_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmans",
                        principalColumn: "DepartmanId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Students_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "PeriodId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CourseSelections",
                columns: table => new
                {
                    CourseSelectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSelections", x => x.CourseSelectionId);
                    table.ForeignKey(
                        name: "FK_CourseSelections_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSelections_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseSelections_LessonId",
                table: "CourseSelections",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSelections_StudentId",
                table: "CourseSelections",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_PeriodId",
                table: "Lessons",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmanId",
                table: "Students",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PeriodId",
                table: "Students",
                column: "PeriodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSelections");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departmans");

            migrationBuilder.DropTable(
                name: "Periods");
        }
    }
}
