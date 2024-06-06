using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestDataAgain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 46, 27, 200, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 6, 6, 13, 46, 27, 200, DateTimeKind.Local).AddTicks(4937) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 42, 56, 838, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 6, 6, 13, 42, 56, 838, DateTimeKind.Local).AddTicks(3097) });
        }
    }
}
