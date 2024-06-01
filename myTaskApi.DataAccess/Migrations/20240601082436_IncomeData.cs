using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class IncomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 6, 1, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5261), new DateTime(2024, 6, 1, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 6, 1, 13, 54, 36, 477, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.InsertData(
                table: "Incomes",
                columns: new[] { "Id", "Amount", "Categories", "description", "start" },
                values: new object[,]
                {
                    { "c001", 450.0, "Utility Income", "receive bording fees", new DateTime(2024, 6, 1, 13, 54, 36, 475, DateTimeKind.Local).AddTicks(2459) },
                    { "c002", 450.0, "Salary", "receive monthly salary", new DateTime(2024, 6, 1, 13, 54, 36, 476, DateTimeKind.Local).AddTicks(2535) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 5, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(2767), new DateTime(2024, 5, 31, 23, 22, 20, 512, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 5, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4083), new DateTime(2024, 5, 31, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 5, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 5, 31, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4092) });
        }
    }
}
