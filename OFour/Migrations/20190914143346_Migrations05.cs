using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OFour.Migrations
{
    public partial class Migrations05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 14, 18, 33, 46, 639, DateTimeKind.Local).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 14, 18, 22, 25, 417, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.CreateTable(
                name: "Certefikates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(20)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: false),
                    FirstNameArm = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    LastNameArm = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(12)", nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certefikates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certefikates");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDay",
                table: "Students",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 14, 18, 22, 25, 417, DateTimeKind.Local).AddTicks(8128),
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldDefaultValue: new DateTime(2019, 9, 14, 18, 33, 46, 639, DateTimeKind.Local).AddTicks(8490));
        }
    }
}
