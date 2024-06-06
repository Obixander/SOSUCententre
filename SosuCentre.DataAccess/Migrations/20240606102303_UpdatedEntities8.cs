using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_Assignment_AssignmentId1",
                table: "MedicineTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_SubTasks_SubTaskId",
                table: "MedicineTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineTasks",
                table: "MedicineTasks");

            migrationBuilder.DropIndex(
                name: "IX_MedicineTasks_AssignmentId1",
                table: "MedicineTasks");

            migrationBuilder.DropColumn(
                name: "SubTaskId",
                table: "MedicineTasks");

            migrationBuilder.RenameColumn(
                name: "SubTaskId",
                table: "SubTasks",
                newName: "MedicineTaskId");

            migrationBuilder.RenameColumn(
                name: "AssignmentId1",
                table: "MedicineTasks",
                newName: "AssignmentId");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId",
                table: "MedicineTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId2",
                table: "MedicineTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineTasks",
                table: "MedicineTasks",
                column: "MedicineTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_AssignmentId2",
                table: "MedicineTasks",
                column: "AssignmentId2");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_Assignment_AssignmentId2",
                table: "MedicineTasks",
                column: "AssignmentId2",
                principalTable: "Assignment",
                principalColumn: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_SubTasks_MedicineTaskId",
                table: "MedicineTasks",
                column: "MedicineTaskId",
                principalTable: "SubTasks",
                principalColumn: "MedicineTaskId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_Assignment_AssignmentId2",
                table: "MedicineTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineTasks_SubTasks_MedicineTaskId",
                table: "MedicineTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineTasks",
                table: "MedicineTasks");

            migrationBuilder.DropIndex(
                name: "IX_MedicineTasks_AssignmentId2",
                table: "MedicineTasks");

            migrationBuilder.DropColumn(
                name: "AssignmentId2",
                table: "MedicineTasks");

            migrationBuilder.RenameColumn(
                name: "MedicineTaskId",
                table: "SubTasks",
                newName: "SubTaskId");

            migrationBuilder.RenameColumn(
                name: "AssignmentId",
                table: "MedicineTasks",
                newName: "AssignmentId1");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId1",
                table: "MedicineTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SubTaskId",
                table: "MedicineTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineTasks",
                table: "MedicineTasks",
                column: "SubTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_AssignmentId1",
                table: "MedicineTasks",
                column: "AssignmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_Assignment_AssignmentId1",
                table: "MedicineTasks",
                column: "AssignmentId1",
                principalTable: "Assignment",
                principalColumn: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineTasks_SubTasks_SubTaskId",
                table: "MedicineTasks",
                column: "SubTaskId",
                principalTable: "SubTasks",
                principalColumn: "SubTaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
