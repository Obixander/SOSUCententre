using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TestDataAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 1);

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "MedicineTasks",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "Notes", "TimeEnd", "TimeStart" },
                values: new object[] { "PlaceHolder", new DateTime(2024, 6, 7, 11, 46, 14, 426, DateTimeKind.Local).AddTicks(7805), new DateTime(2024, 6, 7, 9, 46, 14, 426, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "AssignmentId", "Completed", "Notes", "ResidentId", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 2, false, "PlaceHolder", 1, new DateTime(2024, 6, 7, 12, 46, 14, 426, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 6, 7, 11, 46, 14, 426, DateTimeKind.Local).AddTicks(7824) },
                    { 3, false, "PlaceHolder", 1, new DateTime(2024, 6, 7, 14, 46, 14, 426, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 6, 7, 12, 46, 14, 426, DateTimeKind.Local).AddTicks(7839) },
                    { 4, false, "PlaceHolder", 1, new DateTime(2024, 6, 7, 18, 46, 14, 426, DateTimeKind.Local).AddTicks(7855), new DateTime(2024, 6, 7, 15, 46, 14, 426, DateTimeKind.Local).AddTicks(7854) },
                    { 5, false, "PlaceHolder", 1, new DateTime(2024, 6, 7, 20, 46, 14, 426, DateTimeKind.Local).AddTicks(7871), new DateTime(2024, 6, 7, 18, 46, 14, 426, DateTimeKind.Local).AddTicks(7869) }
                });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "SubTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[,]
                {
                    { 2, 1, false, "Hjælp med medicin" },
                    { 3, 1, false, "Planlægning af måltider" },
                    { 4, 1, false, "Overvågning af helbred" },
                    { 5, 2, false, "Transport til aftaler" },
                    { 6, 2, false, "Rengøring" },
                    { 7, 3, false, "Indkøb" },
                    { 8, 3, false, "Social kontakt" },
                    { 9, 3, false, "Assistance med daglig pleje" },
                    { 10, 4, false, "Hjælp med regninger" },
                    { 11, 4, false, "Planlægning af aktiviteter" },
                    { 12, 4, false, "Hjælp med teknologi" },
                    { 13, 5, false, "Følelsesmæssig støtte" },
                    { 14, 5, false, "Koordinering med sundhedstjenester" },
                    { 15, 5, false, "Støtte til mobilitet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "SubTaskId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "MedicineTasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "Notes", "TimeEnd", "TimeStart" },
                values: new object[] { "Husk at give vand med medicinet", new DateTime(2024, 6, 7, 11, 24, 9, 239, DateTimeKind.Local).AddTicks(2569), new DateTime(2024, 6, 7, 9, 24, 9, 239, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicineAssignmentId", "IsCompleted", "MedicineId", "Name", "Unit" },
                values: new object[] { 1, 2, 1, false, 1, null, "dl" });
        }
    }
}
