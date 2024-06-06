using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class ReportEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReportNo = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isuse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 51, 51, 34, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 6, 5, 21, 51, 51, 34, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 51, 51, 35, DateTimeKind.Local).AddTicks(1928), new DateTime(2024, 6, 5, 21, 51, 51, 35, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 51, 51, 35, DateTimeKind.Local).AddTicks(1954), new DateTime(2024, 6, 5, 21, 51, 51, 35, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 5, 21, 51, 51, 34, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 5, 21, 51, 51, 34, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Description", "Isuse", "ReportName", "ReportNo", "UserId" },
                values: new object[] { 1, "monthly expenses summary..", new DateTime(2024, 6, 5, 21, 51, 51, 28, DateTimeKind.Local).AddTicks(463), "Expense", 1, 100 });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(7113), new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c00b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 56, 18, 43, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c01b",
                column: "start",
                value: new DateTime(2024, 6, 5, 19, 56, 18, 44, DateTimeKind.Local).AddTicks(3739));
        }
    }
}
