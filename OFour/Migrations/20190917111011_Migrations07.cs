using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OFour.Migrations
{
    public partial class Migrations07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 15, 10, 11, 54, DateTimeKind.Local).AddTicks(6934),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 17, 14, 11, 46, 316, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Admins",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 14, 11, 46, 316, DateTimeKind.Local).AddTicks(3988),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 17, 15, 10, 11, 54, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Admins",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");
        }
    }
}
