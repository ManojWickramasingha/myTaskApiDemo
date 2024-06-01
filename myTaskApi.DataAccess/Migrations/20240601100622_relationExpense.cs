using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class relationExpense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "UserId", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(5621), 100, new DateTime(2024, 6, 1, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "UserId", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6805), 101, new DateTime(2024, 6, 1, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "UserId", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6813), 102, new DateTime(2024, 6, 1, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 1, 15, 36, 21, 934, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 1, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Users_UserId",
                table: "Expenses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Users_UserId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Expenses");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 6, 1, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 6, 1, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 6, 1, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 1, 15, 29, 45, 704, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 1, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(3467));
        }
    }
}
