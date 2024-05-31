using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class AuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 45, 24, 569, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 5, 18, 18, 45, 24, 569, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 45, 24, 569, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 5, 18, 18, 45, 24, 569, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 20, 18, 45, 24, 569, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 5, 18, 18, 45, 24, 568, DateTimeKind.Local).AddTicks(4417) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 42, 51, 70, DateTimeKind.Local).AddTicks(8261), new DateTime(2024, 5, 18, 18, 42, 51, 70, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 42, 51, 70, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 5, 18, 18, 42, 51, 70, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 20, 18, 42, 51, 70, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 5, 18, 18, 42, 51, 69, DateTimeKind.Local).AddTicks(3210) });
        }
    }
}
