using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntitie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "EmployeeTask");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_TaskId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Administered",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Medicines");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Tasks",
                newName: "AssignmentId");

            migrationBuilder.CreateTable(
                name: "AssignmentEmployee",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    TasksAssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentEmployee", x => new { x.EmployeesEmployeeId, x.TasksAssignmentId });
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Tasks_TasksAssignmentId",
                        column: x => x.TasksAssignmentId,
                        principalTable: "Tasks",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    SubTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    MedicineTaskType = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.SubTaskId);
                    table.ForeignKey(
                        name: "FK_SubTasks_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "MedicineId");
                });

            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "CareCenterId", "Name", "Notes", "RoomNumber" },
                values: new object[,]
                {
                    { 2, 1, "Lars Ulrich", "Plays drums loudly", "21" },
                    { 3, 1, "Nina Hagen", "Loves punk rock", "15" },
                    { 4, 1, "Bjork Gudmundsdottir", "Has an artistic flair", "27" },
                    { 5, 1, "Sigur Ros", "Enjoys quiet environments", "12" },
                    { 6, 1, "Annie Lennox", "Sings beautifully", "45" },
                    { 7, 1, "David Bowie", "Loves stardust", "33" },
                    { 8, 1, "Freddie Mercury", "Champions the world", "18" },
                    { 9, 1, "Elvis Presley", "King of rock and roll", "22" },
                    { 10, 1, "Aretha Franklin", "Queen of soul", "29" }
                });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "SubTaskId", "IsCompleted", "MedicineTaskType", "Name" },
                values: new object[] { 1, false, "SubTask", "Giv vand" });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "SubTaskId", "Amount", "IsCompleted", "MedicineId", "MedicineTaskType", "Name", "Unit" },
                values: new object[] { 2, 2, false, 1, "MedicineTask", null, "dl" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 13, 49, 16, 782, DateTimeKind.Local).AddTicks(3464), new DateTime(2024, 6, 6, 11, 49, 16, 782, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentEmployee_TasksAssignmentId",
                table: "AssignmentEmployee",
                column: "TasksAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_MedicineId",
                table: "SubTasks",
                column: "MedicineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentEmployee");

            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "AssignmentId",
                table: "Tasks",
                newName: "TaskId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Administered",
                table: "Medicines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeTask",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    TasksTaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTask", x => new { x.EmployeesEmployeeId, x.TasksTaskId });
                    table.ForeignKey(
                        name: "FK_EmployeeTask_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTask_Tasks_TasksTaskId",
                        column: x => x.TasksTaskId,
                        principalTable: "Tasks",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 1,
                columns: new[] { "Administered", "Amount", "TaskId", "Unit" },
                values: new object[] { false, 20, 1, "mg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "Name", "TimeEnd", "TimeStart" },
                values: new object[] { "Giv Medicin", new DateTime(2024, 5, 23, 16, 39, 40, 440, DateTimeKind.Local).AddTicks(322), new DateTime(2024, 5, 23, 14, 39, 40, 440, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_TaskId",
                table: "Medicines",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTask_TasksTaskId",
                table: "EmployeeTask",
                column: "TasksTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");
        }
    }
}
