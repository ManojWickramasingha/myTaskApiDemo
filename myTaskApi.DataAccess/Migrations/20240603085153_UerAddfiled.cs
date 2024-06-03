using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class UerAddfiled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressNo",
                table: "Users",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 14, 21, 52, 693, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 6, 3, 14, 21, 52, 693, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 14, 21, 52, 693, DateTimeKind.Local).AddTicks(5079), new DateTime(2024, 6, 3, 14, 21, 52, 693, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 14, 21, 52, 693, DateTimeKind.Local).AddTicks(5090), new DateTime(2024, 6, 3, 14, 21, 52, 693, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 14, 21, 52, 692, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 14, 21, 52, 693, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { 45, "Colombo", "Lake round" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { 50, "Nugegoda", "Charls road" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { 121, "Kadawatha", "Pilip road" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { 30, "Colombo", "Lotus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(2094), new DateTime(2024, 6, 3, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4112), new DateTime(2024, 6, 3, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4128), new DateTime(2024, 6, 3, 13, 4, 6, 444, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 13, 4, 6, 442, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 13, 4, 6, 443, DateTimeKind.Local).AddTicks(7688));
        }
    }
}
