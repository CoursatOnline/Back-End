using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class modifingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Show",
                table: "Cart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(6043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(5429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(4605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(3888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(5032));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(7102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(6424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(5737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 9, 1, 28, 55, 510, DateTimeKind.Local).AddTicks(5032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 11, 14, 50, 26, 261, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.AddColumn<bool>(
                name: "Show",
                table: "Cart",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }
    }
}
