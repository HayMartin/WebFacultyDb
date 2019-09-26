using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OFour.Migrations
{
    public partial class Migration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 13, 16, 49, 16, 55, DateTimeKind.Local).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 13, 16, 20, 43, 505, DateTimeKind.Local).AddTicks(1230));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 13, 16, 20, 43, 505, DateTimeKind.Local).AddTicks(1230),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 13, 16, 49, 16, 55, DateTimeKind.Local).AddTicks(2990));
        }
    }
}
