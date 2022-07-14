using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class updateRatingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Course_CrsId",
                table: "Rating");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.AlterColumn<int>(
                name: "CrsId",
                table: "Rating",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(7709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(7231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Course_CrsId",
                table: "Rating",
                column: "CrsId",
                principalTable: "Course",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Course_CrsId",
                table: "Rating");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(5470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.AlterColumn<int>(
                name: "CrsId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(4699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(4069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 12, 10, 54, 8, 235, DateTimeKind.Local).AddTicks(3476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 12, 12, 22, 56, 584, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Course_CrsId",
                table: "Rating",
                column: "CrsId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
