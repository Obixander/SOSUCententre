using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestDataAgain7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 5, 45, 722, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 6, 6, 14, 5, 45, 722, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "SubTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[] { 1, 1, false, "Giv vand" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 5, 20, 729, DateTimeKind.Local).AddTicks(1805), new DateTime(2024, 6, 6, 14, 5, 20, 729, DateTimeKind.Local).AddTicks(1762) });
        }
    }
}
