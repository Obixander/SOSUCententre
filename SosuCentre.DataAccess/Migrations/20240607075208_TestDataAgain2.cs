using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TestDataAgain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 11, 52, 7, 708, DateTimeKind.Local).AddTicks(1909), new DateTime(2024, 6, 7, 9, 52, 7, 708, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 12, 52, 7, 708, DateTimeKind.Local).AddTicks(1929), new DateTime(2024, 6, 7, 11, 52, 7, 708, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 14, 52, 7, 708, DateTimeKind.Local).AddTicks(1945), new DateTime(2024, 6, 7, 12, 52, 7, 708, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 18, 52, 7, 708, DateTimeKind.Local).AddTicks(1960), new DateTime(2024, 6, 7, 15, 52, 7, 708, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 20, 52, 7, 708, DateTimeKind.Local).AddTicks(1976), new DateTime(2024, 6, 7, 18, 52, 7, 708, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicineAssignmentId", "IsCompleted", "MedicineId", "Name", "Unit" },
                values: new object[,]
                {
                    { 1, 2.0, 1, false, 7, "PlaceHolder", "dl" },
                    { 2, 1.0, 1, false, 3, "PlaceHolder", "tablet" },
                    { 3, 5.0, 1, false, 9, "PlaceHolder", "ml" },
                    { 4, 2.5, 1, false, 2, "PlaceHolder", "g" },
                    { 5, 10.0, 1, false, 10, "PlaceHolder", "mg" },
                    { 6, 20.0, 2, false, 1, "PlaceHolder", "ml" },
                    { 7, 0.5, 2, false, 6, "PlaceHolder", "l" },
                    { 8, 15.0, 3, false, 8, "PlaceHolder", "units" },
                    { 9, 1.5, 3, false, 4, "PlaceHolder", "teaspoon" },
                    { 10, 3.0, 3, false, 5, "PlaceHolder", "tablespoon" },
                    { 11, 30.0, 4, false, 2, "PlaceHolder", "ml" },
                    { 12, 50.0, 4, false, 7, "PlaceHolder", "mg" },
                    { 13, 4.0, 4, false, 3, "PlaceHolder", "capsules" },
                    { 14, 0.25, 5, false, 1, "PlaceHolder", "liters" },
                    { 15, 75.0, 5, false, 5, "PlaceHolder", "units" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 11, 46, 14, 426, DateTimeKind.Local).AddTicks(7805), new DateTime(2024, 6, 7, 9, 46, 14, 426, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 12, 46, 14, 426, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 6, 7, 11, 46, 14, 426, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 14, 46, 14, 426, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 6, 7, 12, 46, 14, 426, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 18, 46, 14, 426, DateTimeKind.Local).AddTicks(7855), new DateTime(2024, 6, 7, 15, 46, 14, 426, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 7, 20, 46, 14, 426, DateTimeKind.Local).AddTicks(7871), new DateTime(2024, 6, 7, 18, 46, 14, 426, DateTimeKind.Local).AddTicks(7869) });
        }
    }
}
