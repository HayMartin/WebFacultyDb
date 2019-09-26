using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OFour.Migrations
{
    public partial class Migrations08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Certefikates");

            migrationBuilder.DropColumn(
                name: "FirstNameArm",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastNameArm",
                table: "Students");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 20, 14, 30, 0, 19, DateTimeKind.Local).AddTicks(281),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 17, 15, 10, 11, 54, DateTimeKind.Local).AddTicks(6934));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 17, 15, 10, 11, 54, DateTimeKind.Local).AddTicks(6934),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 20, 14, 30, 0, 19, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.AddColumn<string>(
                name: "FirstNameArm",
                table: "Students",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastNameArm",
                table: "Students",
                type: "nvarchar(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certefikates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(20)", nullable: false),
                    FirstNameArm = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: false),
                    LastNameArm = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certefikates", x => x.Id);
                });
        }
    }
}
