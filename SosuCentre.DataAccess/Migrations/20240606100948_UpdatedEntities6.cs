using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentEmployee_Tasks_TasksAssignmentId",
                table: "AssignmentEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Residents_ResidentId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Assignment");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ResidentId",
                table: "Assignment",
                newName: "IX_Assignment_ResidentId");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId1",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicineTaskId",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_AssignmentId",
                table: "SubTasks",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_AssignmentId1",
                table: "SubTasks",
                column: "AssignmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Residents_ResidentId",
                table: "Assignment",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentEmployee_Assignment_TasksAssignmentId",
                table: "AssignmentEmployee",
                column: "TasksAssignmentId",
                principalTable: "Assignment",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Assignment_AssignmentId",
                table: "SubTasks",
                column: "AssignmentId",
                principalTable: "Assignment",
                principalColumn: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Assignment_AssignmentId1",
                table: "SubTasks",
                column: "AssignmentId1",
                principalTable: "Assignment",
                principalColumn: "AssignmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Residents_ResidentId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentEmployee_Assignment_TasksAssignmentId",
                table: "AssignmentEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Assignment_AssignmentId",
                table: "SubTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Assignment_AssignmentId1",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_AssignmentId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_AssignmentId1",
                table: "SubTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "AssignmentId1",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "MedicineTaskId",
                table: "SubTasks");

            migrationBuilder.RenameTable(
                name: "Assignment",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_ResidentId",
                table: "Tasks",
                newName: "IX_Tasks_ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentEmployee_Tasks_TasksAssignmentId",
                table: "AssignmentEmployee",
                column: "TasksAssignmentId",
                principalTable: "Tasks",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Residents_ResidentId",
                table: "Tasks",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "ResidentId");
        }
    }
}
