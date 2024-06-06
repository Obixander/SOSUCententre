using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestDataAgain3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_SubTasks_MedicineTaskId",
                table: "MedicineTasks");

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "MedicineTaskId",
                table: "SubTasks",
                newName: "SubTaskId");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineTaskId",
                table: "MedicineTasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "MedicineTasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MedicineTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 56, 14, 6, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 6, 6, 13, 56, 14, 6, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicinAssignmentId", "IsCompleted", "MedicineId", "Name", "Unit" },
                values: new object[] { 1, 2, null, false, 1, null, "dl" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "MedicineTasks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MedicineTasks");

            migrationBuilder.RenameColumn(
                name: "SubTaskId",
                table: "SubTasks",
                newName: "MedicineTaskId");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineTaskId",
                table: "MedicineTasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 46, 27, 200, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 6, 6, 13, 46, 27, 200, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "MedicineTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[] { 2, null, false, null });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicinAssignmentId", "MedicineId", "Unit" },
                values: new object[] { 2, 2, null, 1, "dl" });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_SubTasks_MedicineTaskId",
                table: "MedicineTasks",
                column: "MedicineTaskId",
                principalTable: "SubTasks",
                principalColumn: "MedicineTaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
