using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class editimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 349, DateTimeKind.Local).AddTicks(3089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 349, DateTimeKind.Local).AddTicks(2535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(2385));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(3127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 349, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 349, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(2708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 14, 30, 215, DateTimeKind.Local).AddTicks(2385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(7418));
        }
    }
}
