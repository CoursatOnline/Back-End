using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class updatingCategoryCourseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(6327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(5926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(5499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(4633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(207));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 13, 0, 33, 807, DateTimeKind.Local).AddTicks(4633));
        }
    }
}
