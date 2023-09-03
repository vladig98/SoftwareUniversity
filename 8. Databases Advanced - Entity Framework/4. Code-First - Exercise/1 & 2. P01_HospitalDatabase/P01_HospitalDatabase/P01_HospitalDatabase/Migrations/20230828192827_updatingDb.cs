using Microsoft.EntityFrameworkCore.Migrations;

namespace P01_HospitalDatabase.Migrations
{
    public partial class updatingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_DoctorId",
                table: "Visitations");

            migrationBuilder.RenameColumn(
                name: "Speciality",
                table: "Doctors",
                newName: "Specialty");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Visitations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_DoctorId",
                table: "Visitations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_DoctorId",
                table: "Visitations");

            migrationBuilder.RenameColumn(
                name: "Specialty",
                table: "Doctors",
                newName: "Speciality");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Visitations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_DoctorId",
                table: "Visitations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
