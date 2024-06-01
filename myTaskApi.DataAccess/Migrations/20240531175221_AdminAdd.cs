using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class AdminAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Adminid",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "manoj" },
                    { 2, "Lahiru" },
                    { 3, "kasun" },
                    { 4, "malindu" },
                    { 5, "Amila" }
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Adminid", "Due", "created" },
                values: new object[] { 1, new DateTime(2024, 6, 5, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(2767), new DateTime(2024, 5, 31, 23, 22, 20, 512, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "id", "Adminid", "Amount", "Description", "Due", "created", "status", "title" },
                values: new object[] { 3, 1, 3780.0, "Goverment Tax Added current bill", new DateTime(2024, 6, 5, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 5, 31, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4092), 0, "Expense For Current bill" });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "id", "Adminid", "Amount", "Description", "Due", "created", "status", "title" },
                values: new object[] { 2, 2, 3890.0, "Goverment Tax Added water bill", new DateTime(2024, 6, 5, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4083), new DateTime(2024, 5, 31, 23, 22, 20, 513, DateTimeKind.Local).AddTicks(4077), 0, "Expense For Water bill" });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_Adminid",
                table: "Expenses",
                column: "Adminid");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Admins_Adminid",
                table: "Expenses",
                column: "Adminid",
                principalTable: "Admins",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Admins_Adminid",
                table: "Expenses");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_Adminid",
                table: "Expenses");

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Adminid",
                table: "Expenses");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 35, 5, 317, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 5, 31, 22, 35, 5, 316, DateTimeKind.Local).AddTicks(6551) });
        }
    }
}
