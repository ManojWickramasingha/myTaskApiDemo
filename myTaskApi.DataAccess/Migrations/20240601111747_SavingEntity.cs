using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class SavingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Savings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Savings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Savings_Users_UserId",
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
                values: new object[] { new DateTime(2024, 6, 6, 16, 47, 46, 816, DateTimeKind.Local).AddTicks(1235), new DateTime(2024, 6, 1, 16, 47, 46, 816, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 47, 46, 816, DateTimeKind.Local).AddTicks(2393), new DateTime(2024, 6, 1, 16, 47, 46, 816, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 47, 46, 816, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 6, 1, 16, 47, 46, 816, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 1, 16, 47, 46, 814, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 1, 16, 47, 46, 815, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.InsertData(
                table: "Savings",
                columns: new[] { "Id", "Description", "Name", "UserId" },
                values: new object[,]
                {
                    { 10, "Saving montlty utility Income", "manoj", 100 },
                    { 12, "Saving Salary", "Lahiru", 101 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Savings_UserId",
                table: "Savings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Savings");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(5621), new DateTime(2024, 6, 1, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 6, 1, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6813), new DateTime(2024, 6, 1, 15, 36, 21, 935, DateTimeKind.Local).AddTicks(6812) });

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
        }
    }
}
