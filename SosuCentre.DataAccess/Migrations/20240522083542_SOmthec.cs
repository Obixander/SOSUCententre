using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SOmthec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTask_Task_TasksTaskId",
                table: "EmployeeTask");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Task_TaskId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Residents_ResidentId",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_Task_ResidentId",
                table: "Tasks",
                newName: "IX_Tasks_ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "TaskId");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1,
                column: "State",
                value: "Syd Jylland");

            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "CareCenterId", "Name", "Notes", "RoomNumber" },
                values: new object[] { 1, 1, "Mads Mikkel", "HE Suck big fat", "32" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTask_Tasks_TasksTaskId",
                table: "EmployeeTask",
                column: "TasksTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Residents_ResidentId",
                table: "Tasks",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTask_Tasks_TasksTaskId",
                table: "EmployeeTask");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Residents_ResidentId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Task");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ResidentId",
                table: "Task",
                newName: "IX_Task_ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "TaskId");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1,
                column: "State",
                value: "Midt Jylland");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTask_Task_TasksTaskId",
                table: "EmployeeTask",
                column: "TasksTaskId",
                principalTable: "Task",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Task_TaskId",
                table: "Medicines",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Residents_ResidentId",
                table: "Task",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
