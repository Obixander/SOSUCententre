using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntities1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MedicineTaskType",
                table: "SubTasks",
                newName: "Discriminator");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 13, 52, 40, 704, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 6, 6, 11, 52, 40, 704, DateTimeKind.Local).AddTicks(3881) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "SubTasks",
                newName: "MedicineTaskType");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 6, 13, 49, 16, 782, DateTimeKind.Local).AddTicks(3464), new DateTime(2024, 6, 6, 11, 49, 16, 782, DateTimeKind.Local).AddTicks(3424) });
        }
    }
}
