using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 42, 4, 564, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 6, 13, 8, 42, 4, 564, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 42, 4, 564, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 6, 13, 10, 42, 4, 564, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 42, 4, 564, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 6, 13, 11, 42, 4, 564, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 42, 4, 564, DateTimeKind.Local).AddTicks(9201), new DateTime(2024, 6, 13, 14, 42, 4, 564, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 19, 42, 4, 564, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 6, 13, 17, 42, 4, 564, DateTimeKind.Local).AddTicks(9215) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 10, 10, 45, 42, 445, DateTimeKind.Local).AddTicks(1599), new DateTime(2024, 6, 10, 8, 45, 42, 445, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 10, 11, 45, 42, 445, DateTimeKind.Local).AddTicks(1654), new DateTime(2024, 6, 10, 10, 45, 42, 445, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 10, 13, 45, 42, 445, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 6, 10, 11, 45, 42, 445, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 45, 42, 445, DateTimeKind.Local).AddTicks(1685), new DateTime(2024, 6, 10, 14, 45, 42, 445, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 45, 42, 445, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 6, 10, 17, 45, 42, 445, DateTimeKind.Local).AddTicks(1698) });
        }
    }
}
