using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class UpdateEBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EBudgets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "EBudgets",
                keyColumn: "id",
                keyValue: "c00B",
                column: "UserId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "EBudgets",
                keyColumn: "id",
                keyValue: "c01B",
                column: "UserId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6353), new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 45, 17, 297, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 45, 17, 299, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.CreateIndex(
                name: "IX_EBudgets_UserId",
                table: "EBudgets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EBudgets_Users_UserId",
                table: "EBudgets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EBudgets_Users_UserId",
                table: "EBudgets");

            migrationBuilder.DropIndex(
                name: "IX_EBudgets_UserId",
                table: "EBudgets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EBudgets");

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
    }
}
