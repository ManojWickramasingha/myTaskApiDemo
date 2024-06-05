using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class addedrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 22, 50, 33, 923, DateTimeKind.Local).AddTicks(543), new DateTime(2024, 6, 4, 22, 50, 33, 923, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 22, 50, 33, 923, DateTimeKind.Local).AddTicks(2456), new DateTime(2024, 6, 4, 22, 50, 33, 923, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 22, 50, 33, 923, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 6, 4, 22, 50, 33, 923, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 4, 22, 50, 33, 921, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 4, 22, 50, 33, 922, DateTimeKind.Local).AddTicks(5745));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(1225), new DateTime(2024, 6, 4, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 6, 4, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 9, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 6, 4, 21, 40, 3, 65, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 4, 21, 40, 3, 63, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 4, 21, 40, 3, 64, DateTimeKind.Local).AddTicks(8349));
        }
    }
}
