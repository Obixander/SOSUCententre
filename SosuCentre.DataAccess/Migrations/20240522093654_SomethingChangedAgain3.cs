using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SomethingChangedAgain3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 36, 54, 203, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 5, 22, 11, 36, 54, 203, DateTimeKind.Local).AddTicks(7037) });
        }
    }
}
