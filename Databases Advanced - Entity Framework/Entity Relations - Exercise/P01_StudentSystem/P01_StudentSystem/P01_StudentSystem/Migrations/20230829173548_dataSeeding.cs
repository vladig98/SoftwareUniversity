using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P01_StudentSystem.Migrations
{
    public partial class dataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[] { 1, "Description", new DateTime(2023, 9, 1, 20, 35, 48, 332, DateTimeKind.Local), "Course1", 59.99m, new DateTime(2023, 8, 29, 20, 35, 48, 330, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Birthday", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[] { 1, new DateTime(2001, 8, 29, 20, 35, 48, 342, DateTimeKind.Local), "Student1", "5555555555", new DateTime(2023, 8, 29, 20, 35, 48, 342, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "HomeworkId", "Content", "ContentType", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[] { 1, "Content", 1, 1, 1, new DateTime(2023, 8, 29, 20, 35, 48, 338, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[] { 1, 1, "Resource1", 2, "URL" });

            migrationBuilder.InsertData(
                table: "StudentsCourses",
                columns: new[] { "StudentId", "CourseId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentsCourses",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);
        }
    }
}
