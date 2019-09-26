using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OFour.Migrations
{
    public partial class Migrations06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Subjects");

            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "Subjects",
                type: "nvarchar(40)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 14, 11, 46, 316, DateTimeKind.Local).AddTicks(3988),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 14, 18, 33, 46, 639, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.AlterColumn<int>(
                name: "TeacherID",
                table: "Cources",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "Cources",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "Subjects");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "varchar(40)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 14, 18, 33, 46, 639, DateTimeKind.Local).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 17, 14, 11, 46, 316, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.AlterColumn<int>(
                name: "TeacherID",
                table: "Cources",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "Cources",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
