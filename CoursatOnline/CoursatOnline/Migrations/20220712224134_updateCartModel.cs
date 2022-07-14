using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class updateCartModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(8573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(8125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(7668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(7062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(3888));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(6043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(5429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(4605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(3888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 13, 0, 41, 33, 521, DateTimeKind.Local).AddTicks(7062));
        }
    }
}
