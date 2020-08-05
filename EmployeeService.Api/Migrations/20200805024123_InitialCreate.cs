using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesAPIService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "JobGrade",
                columns: table => new
                {
                    JobGradeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobGradeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGrade", x => x.JobGradeID);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    JobTitleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobTitleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleID);
                });

            migrationBuilder.CreateTable(
                name: "RecruitmentRequisition",
                columns: table => new
                {
                    RecruitmentRequisitionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentID = table.Column<int>(nullable: false),
                    JobTitleID = table.Column<int>(nullable: false),
                    JobGradeID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitmentRequisition", x => x.RecruitmentRequisitionID);
                    table.ForeignKey(
                        name: "FK_RecruitmentRequisition_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecruitmentRequisition_JobGrade_JobGradeID",
                        column: x => x.JobGradeID,
                        principalTable: "JobGrade",
                        principalColumn: "JobGradeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecruitmentRequisition_JobTitle_JobTitleID",
                        column: x => x.JobTitleID,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    EmployeeNumber = table.Column<string>(nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    RecruitmentRequisitionID = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_RecruitmentRequisition_RecruitmentRequisitionID",
                        column: x => x.RecruitmentRequisitionID,
                        principalTable: "RecruitmentRequisition",
                        principalColumn: "RecruitmentRequisitionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                table: "Employee",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RecruitmentRequisitionID",
                table: "Employee",
                column: "RecruitmentRequisitionID");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitmentRequisition_DepartmentID",
                table: "RecruitmentRequisition",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitmentRequisition_JobGradeID",
                table: "RecruitmentRequisition",
                column: "JobGradeID");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitmentRequisition_JobTitleID",
                table: "RecruitmentRequisition",
                column: "JobTitleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "RecruitmentRequisition");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "JobGrade");

            migrationBuilder.DropTable(
                name: "JobTitle");
        }
    }
}
