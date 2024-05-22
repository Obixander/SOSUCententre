using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SomethingChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTask_Employees_EmployeesEmployeeId",
                table: "EmployeeTask");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTask_Tasks_TasksTaskId",
                table: "EmployeeTask");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTask",
                table: "EmployeeTask");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Roles");

            migrationBuilder.RenameTable(
                name: "EmployeeTask",
                newName: "TaskEmployees");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTask_TasksTaskId",
                table: "TaskEmployees",
                newName: "IX_TaskEmployees_TasksTaskId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Residents",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Residents",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Residents",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Prescriptions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Medicines",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskEmployees",
                table: "TaskEmployees",
                columns: new[] { "EmployeesEmployeeId", "TasksTaskId" });

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => new { x.EmployeesEmployeeId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoles_RoleId",
                table: "EmployeeRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskEmployees_Employees_EmployeesEmployeeId",
                table: "TaskEmployees",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskEmployees_Tasks_TasksTaskId",
                table: "TaskEmployees",
                column: "TasksTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskEmployees_Employees_EmployeesEmployeeId",
                table: "TaskEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskEmployees_Tasks_TasksTaskId",
                table: "TaskEmployees");

            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskEmployees",
                table: "TaskEmployees");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "TaskEmployees",
                newName: "EmployeeTask");

            migrationBuilder.RenameIndex(
                name: "IX_TaskEmployees_TasksTaskId",
                table: "EmployeeTask",
                newName: "IX_EmployeeTask_TasksTaskId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Prescriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTask",
                table: "EmployeeTask",
                columns: new[] { "EmployeesEmployeeId", "TasksTaskId" });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTask_Employees_EmployeesEmployeeId",
                table: "EmployeeTask",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTask_Tasks_TasksTaskId",
                table: "EmployeeTask",
                column: "TasksTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
