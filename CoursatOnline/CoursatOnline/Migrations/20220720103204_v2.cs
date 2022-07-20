using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisteredStudent",
                table: "RegisteredStudent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(5424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(5025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(4559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisteredStudent",
                table: "RegisteredStudent",
                column: "StdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisteredStudent",
                table: "RegisteredStudent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(4788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(4398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(4017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 12, 27, 7, 680, DateTimeKind.Local).AddTicks(3600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 12, 32, 3, 848, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisteredStudent",
                table: "RegisteredStudent",
                columns: new[] { "StdId", "PaymentId" });
        }
    }
}
