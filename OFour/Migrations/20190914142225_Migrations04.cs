using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OFour.Migrations
{
    public partial class Migrations04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 14, 18, 22, 25, 417, DateTimeKind.Local).AddTicks(8128),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 13, 16, 49, 16, 55, DateTimeKind.Local).AddTicks(2990));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 13, 16, 49, 16, 55, DateTimeKind.Local).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 14, 18, 22, 25, 417, DateTimeKind.Local).AddTicks(8128));
        }
    }
}
