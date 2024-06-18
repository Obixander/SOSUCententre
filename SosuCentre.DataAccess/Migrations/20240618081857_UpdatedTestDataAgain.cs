using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTestDataAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 18, 57, 76, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 6, 18, 10, 18, 57, 76, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 18, 57, 76, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 6, 18, 12, 18, 57, 76, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 18, 57, 76, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 6, 18, 13, 18, 57, 76, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 19, 18, 57, 76, DateTimeKind.Local).AddTicks(7965), new DateTime(2024, 6, 18, 16, 18, 57, 76, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 21, 18, 57, 76, DateTimeKind.Local).AddTicks(7986), new DateTime(2024, 6, 18, 19, 18, 57, 76, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 12, 18, 57, 76, DateTimeKind.Local).AddTicks(8010), new DateTime(2024, 6, 19, 10, 18, 57, 76, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 13, 18, 57, 76, DateTimeKind.Local).AddTicks(8032), new DateTime(2024, 6, 19, 12, 18, 57, 76, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 18, 57, 76, DateTimeKind.Local).AddTicks(8056), new DateTime(2024, 6, 19, 13, 18, 57, 76, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 19, 18, 57, 76, DateTimeKind.Local).AddTicks(8082), new DateTime(2024, 6, 19, 16, 18, 57, 76, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 21, 18, 57, 76, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 6, 19, 19, 18, 57, 76, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 15,
                columns: new[] { "Amount", "MedicineAssignmentId", "MedicineId", "Name", "Unit" },
                values: new object[] { 50.0, 7, 4, "Pain Relief Administration", "mg" });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicineAssignmentId", "IsCompleted", "MedicineId", "Name", "Unit" },
                values: new object[,]
                {
                    { 16, 200.0, 8, false, 9, "Antibiotic Course", "mg" },
                    { 17, 1.0, 10, false, 2, "Blood Pressure Medication", "tablet" },
                    { 18, 10.0, 6, false, 5, "Insulin Injection", "units" },
                    { 19, 1000.0, 9, false, 8, "Vitamin D Supplement", "IU" },
                    { 20, 2.0, 10, false, 3, "Heart Medication", "capsules" },
                    { 21, 5.0, 6, false, 7, "Antifungal Treatment", "ml" },
                    { 22, 10.0, 7, false, 6, "Cough Syrup", "ml" },
                    { 23, 25.0, 8, false, 1, "Diuretic Medication", "mg" },
                    { 24, 1.0, 9, false, 10, "Antihistamine Dose", "tablet" },
                    { 25, 65.0, 10, false, 2, "Iron Supplement", "mg" },
                    { 26, 500.0, 6, false, 4, "Calcium Tablet", "mg" },
                    { 27, 1.5, 7, false, 9, "Thyroid Medication", "tablet" },
                    { 28, 20.0, 8, false, 5, "Antidepressant Dosage", "mg" },
                    { 29, 2.0, 9, false, 3, "Eye Drops", "drops" }
                });

            migrationBuilder.UpdateData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 15,
                columns: new[] { "AssignmentId", "Name" },
                values: new object[] { 9, "Patient Medication Administration" });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "SubTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[,]
                {
                    { 16, 8, false, "Elderly Mobility Support" },
                    { 17, 10, false, "Health Monitoring" },
                    { 18, 7, false, "Nutrition Assistance" },
                    { 19, 6, false, "Rehabilitation Exercises" },
                    { 20, 10, false, "Patient Hygiene Support" },
                    { 21, 9, false, "Daily Living Activities" },
                    { 22, 7, false, "Mental Health Support" },
                    { 23, 8, false, "Wound Care" },
                    { 24, 6, false, "Medication Reminders" },
                    { 25, 10, false, "Physical Therapy Assistance" },
                    { 26, 9, false, "Dietary Monitoring" },
                    { 27, 7, false, "Health Check-Ups" },
                    { 28, 8, false, "Patient Record Keeping" },
                    { 29, 6, false, "Emergency Response Preparedness" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 11, 3, 59, 876, DateTimeKind.Local).AddTicks(6500), new DateTime(2024, 6, 18, 9, 3, 59, 876, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 3, 59, 876, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 6, 18, 11, 3, 59, 876, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 14, 3, 59, 876, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 6, 18, 12, 3, 59, 876, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 18, 3, 59, 876, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 6, 18, 15, 3, 59, 876, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 18, 20, 3, 59, 876, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 6, 18, 18, 3, 59, 876, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 11, 3, 59, 876, DateTimeKind.Local).AddTicks(6594), new DateTime(2024, 6, 19, 9, 3, 59, 876, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 12, 3, 59, 876, DateTimeKind.Local).AddTicks(6610), new DateTime(2024, 6, 19, 11, 3, 59, 876, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 14, 3, 59, 876, DateTimeKind.Local).AddTicks(6627), new DateTime(2024, 6, 19, 12, 3, 59, 876, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 18, 3, 59, 876, DateTimeKind.Local).AddTicks(6643), new DateTime(2024, 6, 19, 15, 3, 59, 876, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 19, 20, 3, 59, 876, DateTimeKind.Local).AddTicks(6661), new DateTime(2024, 6, 19, 18, 3, 59, 876, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 15,
                columns: new[] { "Amount", "MedicineAssignmentId", "MedicineId", "Name", "Unit" },
                values: new object[] { 75.0, 5, 5, "PlaceHolder", "units" });

            migrationBuilder.UpdateData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 15,
                columns: new[] { "AssignmentId", "Name" },
                values: new object[] { 5, "Støtte til mobilitet" });
        }
    }
}
