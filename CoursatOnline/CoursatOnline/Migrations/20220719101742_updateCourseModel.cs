using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class updateCourseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6279));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(207));
        }
    }
}
