using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class addValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(8516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPaid",
                table: "Course",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(7771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(7077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(6260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.AlterColumn<bool>(
                name: "IsPaid",
                table: "Course",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 4, 17, 10, 55, 861, DateTimeKind.Local).AddTicks(6260));
        }
    }
}
