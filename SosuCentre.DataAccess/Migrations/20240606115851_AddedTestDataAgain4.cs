using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestDataAgain4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 58, 50, 747, DateTimeKind.Local).AddTicks(4312), new DateTime(2024, 6, 6, 13, 58, 50, 747, DateTimeKind.Local).AddTicks(4271) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 56, 14, 6, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 6, 6, 13, 56, 14, 6, DateTimeKind.Local).AddTicks(2845) });
        }
    }
}
