using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class updatestudentregistermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredStudent_Course__CourseId",
                table: "RegisteredStudent");

            migrationBuilder.RenameColumn(
                name: "_CourseId",
                table: "RegisteredStudent",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_RegisteredStudent__CourseId",
                table: "RegisteredStudent",
                newName: "IX_RegisteredStudent_CourseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 911, DateTimeKind.Local).AddTicks(998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 911, DateTimeKind.Local).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 910, DateTimeKind.Local).AddTicks(9086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 910, DateTimeKind.Local).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredStudent_Course_CourseId",
                table: "RegisteredStudent",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredStudent_Course_CourseId",
                table: "RegisteredStudent");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "RegisteredStudent",
                newName: "_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_RegisteredStudent_CourseId",
                table: "RegisteredStudent",
                newName: "IX_RegisteredStudent__CourseId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(7034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 911, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(6646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 911, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(6213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 910, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 19, 18, 18, 31, 612, DateTimeKind.Local).AddTicks(5817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 20, 2, 22, 36, 910, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredStudent_Course__CourseId",
                table: "RegisteredStudent",
                column: "_CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
