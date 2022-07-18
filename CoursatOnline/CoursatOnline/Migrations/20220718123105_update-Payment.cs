using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursatOnline.Migrations
{
    public partial class updatePayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Payment_PaymentMethod_Enum",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "DateDone",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentAmount",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "PaymentMethod",
                table: "Payment",
                newName: "year");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 513, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.AddColumn<string>(
                name: "cardnumber",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cvc",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "month",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(6268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 512, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(5732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 512, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(5058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 512, DateTimeKind.Local).AddTicks(8498));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cardnumber",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "cvc",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "month",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "value",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "Payment",
                newName: "PaymentMethod");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 513, DateTimeKind.Local).AddTicks(479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDone",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "PaymentAmount",
                table: "Payment",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 512, DateTimeKind.Local).AddTicks(9866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Chapter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 512, DateTimeKind.Local).AddTicks(9269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 14, 5, 17, 10, 512, DateTimeKind.Local).AddTicks(8498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 18, 14, 31, 4, 733, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.AddCheckConstraint(
                name: "CK_Payment_PaymentMethod_Enum",
                table: "Payment",
                sql: "[PaymentMethod] IN (0)");
        }
    }
}
