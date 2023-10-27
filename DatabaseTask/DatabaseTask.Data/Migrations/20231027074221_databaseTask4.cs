using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class databaseTask4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeID");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "SchoolID",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeID");

            migrationBuilder.CreateTable(
                name: "Cupongs",
                columns: table => new
                {
                    CupongID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Worth = table.Column<int>(type: "int", nullable: false),
                    Usable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupongs", x => x.CupongID);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SchoolID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildrenCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SchoolID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_Classes_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_Classes_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "SchoolID");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CupongID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_Students_Cupongs_CupongID",
                        column: x => x.CupongID,
                        principalTable: "Cupongs",
                        principalColumn: "CupongID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SchoolID",
                table: "Employees",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_EmployeeID",
                table: "Classes",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SchoolID",
                table: "Classes",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CupongID",
                table: "Students",
                column: "CupongID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Schools_SchoolID",
                table: "Employees",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchoolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Schools_SchoolID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Cupongs");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SchoolID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Employee",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employee",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Employee",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");
        }
    }
}
