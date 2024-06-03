using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class EBudgetEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "EBudgets",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBudgets", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 6, 3, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 6, 3, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6073), new DateTime(2024, 6, 3, 12, 21, 29, 485, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 21, 29, 482, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 21, 29, 484, DateTimeKind.Local).AddTicks(7731));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EBudgets");

            migrationBuilder.CreateTable(
                name: "BudLimits",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudLimits_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BudLimits",
                columns: new[] { "Id", "Amount", "Description", "UserId" },
                values: new object[,]
                {
                    { "c00b", 3500.4000000000001, "Monthly expense limitage for education", 100 },
                    { "c01b", 4000.0, "Early income limitage for Investment", 100 }
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 12, 31, 54, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 6, 3, 12, 12, 31, 54, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 12, 31, 54, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 6, 3, 12, 12, 31, 54, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 8, 12, 12, 31, 54, DateTimeKind.Local).AddTicks(5992), new DateTime(2024, 6, 3, 12, 12, 31, 54, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 12, 31, 52, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 3, 12, 12, 31, 53, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.CreateIndex(
                name: "IX_BudLimits_UserId",
                table: "BudLimits",
                column: "UserId");
        }
    }
}
