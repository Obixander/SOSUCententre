using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_Assignment_AssignmentId1",
                table: "MedicineTasks");

            migrationBuilder.RenameColumn(
                name: "AssignmentId1",
                table: "MedicineTasks",
                newName: "MedicinAssignmentId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicineTasks_AssignmentId1",
                table: "MedicineTasks",
                newName: "IX_MedicineTasks_MedicinAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_Assignment_MedicinAssignmentId",
                table: "MedicineTasks",
                column: "MedicinAssignmentId",
                principalTable: "Assignment",
                principalColumn: "AssignmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_Assignment_MedicinAssignmentId",
                table: "MedicineTasks");

            migrationBuilder.RenameColumn(
                name: "MedicinAssignmentId",
                table: "MedicineTasks",
                newName: "AssignmentId1");

            migrationBuilder.RenameIndex(
                name: "IX_MedicineTasks_MedicinAssignmentId",
                table: "MedicineTasks",
                newName: "IX_MedicineTasks_AssignmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_Assignment_AssignmentId1",
                table: "MedicineTasks",
                column: "AssignmentId1",
                principalTable: "Assignment",
                principalColumn: "AssignmentId");
        }
    }
}
