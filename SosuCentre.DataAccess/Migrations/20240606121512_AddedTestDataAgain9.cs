using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestDataAgain9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumnType: "int",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "AssignmentId", "Completed", "Notes", "ResidentId", "TimeEnd", "TimeStart" },
                values: new object[] { 1, false, "Husk at give vand med medicinet", 1, new DateTime(2024, 6, 6, 16, 14, 52, 543, DateTimeKind.Local).AddTicks(6960), new DateTime(2024, 6, 6, 14, 14, 52, 543, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicinAssignmentId", "IsCompleted", "MedicineId", "Name", "Unit" },
                values: new object[] { 1, 2, null, false, 1, null, "dl" });
        }
    }
}
