using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SomethingChangedAgain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Medicines",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 255);

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "Completed", "Name", "Notes", "ResidentId", "TimeEnd", "TimeStart" },
                values: new object[] { 1, false, "Giv Medicin", "Husk at give vand med medicinet", 1, new DateTime(2024, 5, 22, 13, 35, 47, 476, DateTimeKind.Local).AddTicks(1314), new DateTime(2024, 5, 22, 11, 35, 47, 476, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Administered", "Amount", "Name", "TaskId", "Unit" },
                values: new object[] { 1, false, 20, "Tyrol", 1, "mg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Medicines",
                type: "int",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }
    }
}
