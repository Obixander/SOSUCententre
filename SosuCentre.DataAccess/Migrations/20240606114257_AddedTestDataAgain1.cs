using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestDataAgain1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "MedicineTaskId",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 42, 56, 838, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 6, 6, 13, 42, 56, 838, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "MedicineTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[] { 2, null, false, null });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicinAssignmentId", "MedicineId", "Unit" },
                values: new object[] { 2, 2, null, 1, "dl" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 30, 10, 407, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 6, 6, 13, 30, 10, 407, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "MedicineTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[] { -1, null, false, null });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicinAssignmentId", "MedicineId", "Unit" },
                values: new object[] { -1, 2, null, 1, "dl" });
        }
    }
}
