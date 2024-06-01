using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class checkData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "id", "Description", "Due", "created", "status", "title" },
                values: new object[] { 10, "Get some text books for school", new DateTime(2024, 5, 23, 13, 48, 19, 717, DateTimeKind.Local).AddTicks(5732), new DateTime(2024, 5, 18, 13, 48, 19, 716, DateTimeKind.Local).AddTicks(1193), 0, "get book for school from DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 10);
        }
    }
}
