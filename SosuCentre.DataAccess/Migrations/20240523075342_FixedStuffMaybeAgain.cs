using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixedStuffMaybeAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 53, 42, 51, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 5, 23, 9, 53, 42, 51, DateTimeKind.Local).AddTicks(6225) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 30, 49, 64, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 5, 23, 9, 30, 49, 64, DateTimeKind.Local).AddTicks(7091) });
        }
    }
}
