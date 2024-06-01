using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class userData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Incomes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Gmail", "Name", "Password" },
                values: new object[,]
                {
                    { 100, "wicmanoj@gmail.com", "manoj", "manoj@123" },
                    { 101, "Menaka@gmail.com", "Menaka", "menaka@123" },
                    { 102, "Ashen@gmail.com", "Ashen", "Ashen@123" },
                    { 103, "Chinthaka@gmail.com", "Chinthaka", "Chinthaka@123" }
                });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                columns: new[] { "UserId", "start" },
                values: new object[] { 100, new DateTime(2024, 6, 1, 15, 29, 45, 704, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                columns: new[] { "UserId", "start" },
                values: new object[] { 102, new DateTime(2024, 6, 1, 15, 29, 45, 705, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UserId",
                table: "Incomes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Users_UserId",
                table: "Incomes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Users_UserId",
                table: "Incomes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_UserId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Incomes");

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

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c001",
                column: "start",
                value: new DateTime(2024, 6, 1, 13, 54, 36, 475, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: "c002",
                column: "start",
                value: new DateTime(2024, 6, 1, 13, 54, 36, 476, DateTimeKind.Local).AddTicks(2535));
        }
    }
}
