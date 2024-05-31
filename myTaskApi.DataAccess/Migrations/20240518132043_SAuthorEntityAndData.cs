using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myTaskApi.DataAccess.Migrations
{
    public partial class SAuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 5, 18, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 5, 18, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "Due", "created" },
                values: new object[] { new DateTime(2024, 5, 20, 18, 50, 43, 321, DateTimeKind.Local).AddTicks(3876), new DateTime(2024, 5, 18, 18, 50, 43, 320, DateTimeKind.Local).AddTicks(3814) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
