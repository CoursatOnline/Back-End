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
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(9529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(5662));
========
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7434));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(9211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(3883));
========
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7069));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(3444));
========
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6742));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(8507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(3059));
========
                defaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6279));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(5662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(9529));
========
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1772));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(9211));
========
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(7069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(1229));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(3444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(8891));
========
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(698));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
<<<<<<<< HEAD:CoursatOnline/CoursatOnline/Migrations/20220719171405_v2.cs
                defaultValue: new DateTime(2022, 7, 19, 19, 9, 28, 932, DateTimeKind.Local).AddTicks(3059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 19, 14, 5, 52, DateTimeKind.Local).AddTicks(8507));
========
                defaultValue: new DateTime(2022, 7, 18, 18, 34, 24, 44, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 19, 12, 17, 41, 533, DateTimeKind.Local).AddTicks(207));
>>>>>>>> f3cc90c5db8f6f2bc5a3224a6457e714c2ab3148:CoursatOnline/CoursatOnline/Migrations/20220719101742_updateCourseModel.cs
        }
    }
}
