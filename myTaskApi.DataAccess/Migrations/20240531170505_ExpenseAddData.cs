using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class ExpenseAddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "id", "Amount", "Description", "Due", "created", "status", "title" },
                values: new object[] { 1, 3000.0, "Get some text books for school", new DateTime(2024, 6, 5, 22, 35, 5, 317, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 5, 31, 22, 35, 5, 316, DateTimeKind.Local).AddTicks(6551), 0, "Expense Tax record in database" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
