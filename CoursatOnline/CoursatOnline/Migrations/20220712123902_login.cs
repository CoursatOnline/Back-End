using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(4560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 140, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(4132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 139, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(3936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 139, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(3703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 139, DateTimeKind.Local).AddTicks(9509));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 140, DateTimeKind.Local).AddTicks(120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 139, DateTimeKind.Local).AddTicks(9934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 139, DateTimeKind.Local).AddTicks(9708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 14, 32, 18, 139, DateTimeKind.Local).AddTicks(9509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 14, 39, 1, 810, DateTimeKind.Local).AddTicks(3703));
        }
    }
}
