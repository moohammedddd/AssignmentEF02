using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02.Migrations
{
    /// <inheritdoc />
    public partial class AfterMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Ins_Id",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CoursIns",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    evaluation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursIns", x => new { x.Ins_Id, x.Course_ID });
                });

            migrationBuilder.CreateTable(
                name: "studentCourses",
                columns: table => new
                {
                    St_ID = table.Column<int>(type: "int", nullable: false),
                    Couse_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourses", x => new { x.St_ID, x.Couse_ID });
                    table.ForeignKey(
                        name: "FK_studentCourses_Courses_Couse_ID",
                        column: x => x.Couse_ID,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentCourses_Students_St_ID",
                        column: x => x.St_ID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursInsCourse",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    CoursInsIns_Id = table.Column<int>(type: "int", nullable: false),
                    CoursInsCourse_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursInsCourse", x => new { x.CoursesId, x.CoursInsIns_Id, x.CoursInsCourse_ID });
                    table.ForeignKey(
                        name: "FK_CoursInsCourse_CoursIns_CoursInsIns_Id_CoursInsCourse_ID",
                        columns: x => new { x.CoursInsIns_Id, x.CoursInsCourse_ID },
                        principalTable: "CoursIns",
                        principalColumns: new[] { "Ins_Id", "Course_ID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursInsCourse_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursInsInstrucotr",
                columns: table => new
                {
                    InstrucotrsIns_Id = table.Column<int>(type: "int", nullable: false),
                    CoursInsIns_Id = table.Column<int>(type: "int", nullable: false),
                    CoursInsCourse_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursInsInstrucotr", x => new { x.InstrucotrsIns_Id, x.CoursInsIns_Id, x.CoursInsCourse_ID });
                    table.ForeignKey(
                        name: "FK_CoursInsInstrucotr_CoursIns_CoursInsIns_Id_CoursInsCourse_ID",
                        columns: x => new { x.CoursInsIns_Id, x.CoursInsCourse_ID },
                        principalTable: "CoursIns",
                        principalColumns: new[] { "Ins_Id", "Course_ID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursInsInstrucotr_Instrucotrs_InstrucotrsIns_Id",
                        column: x => x.InstrucotrsIns_Id,
                        principalTable: "Instrucotrs",
                        principalColumn: "Ins_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instrucotrs_Dept_Id",
                table: "Instrucotrs",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                unique: true,
                filter: "[Ins_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursInsCourse_CoursInsIns_Id_CoursInsCourse_ID",
                table: "CoursInsCourse",
                columns: new[] { "CoursInsIns_Id", "CoursInsCourse_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_CoursInsInstrucotr_CoursInsIns_Id_CoursInsCourse_ID",
                table: "CoursInsInstrucotr",
                columns: new[] { "CoursInsIns_Id", "CoursInsCourse_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_Couse_ID",
                table: "studentCourses",
                column: "Couse_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instrucotrs_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instrucotrs",
                principalColumn: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instrucotrs_Departments_Dept_Id",
                table: "Instrucotrs",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instrucotrs_Ins_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrucotrs_Departments_Dept_Id",
                table: "Instrucotrs");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "CoursInsCourse");

            migrationBuilder.DropTable(
                name: "CoursInsInstrucotr");

            migrationBuilder.DropTable(
                name: "studentCourses");

            migrationBuilder.DropTable(
                name: "CoursIns");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instrucotrs_Dept_Id",
                table: "Instrucotrs");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "Ins_Id",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
