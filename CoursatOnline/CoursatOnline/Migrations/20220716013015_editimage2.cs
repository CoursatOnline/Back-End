using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class editimage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 349, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 349, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

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
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 349, DateTimeKind.Local).AddTicks(2535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 16, 3, 25, 3, 348, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 16, 3, 30, 15, 314, DateTimeKind.Local).AddTicks(6218));
        }
    }
}
