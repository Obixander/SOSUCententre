using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedMedicinNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MedicinNotes",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "MedicinNotes", "TimeEnd", "TimeStart" },
                values: new object[] { null, new DateTime(2024, 6, 16, 12, 41, 2, 695, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 6, 16, 10, 41, 2, 695, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "MedicinNotes", "TimeEnd", "TimeStart" },
                values: new object[] { null, new DateTime(2024, 6, 16, 13, 41, 2, 695, DateTimeKind.Local).AddTicks(2063), new DateTime(2024, 6, 16, 12, 41, 2, 695, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "MedicinNotes", "TimeEnd", "TimeStart" },
                values: new object[] { null, new DateTime(2024, 6, 16, 15, 41, 2, 695, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 6, 16, 13, 41, 2, 695, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "MedicinNotes", "TimeEnd", "TimeStart" },
                values: new object[] { null, new DateTime(2024, 6, 16, 19, 41, 2, 695, DateTimeKind.Local).AddTicks(2083), new DateTime(2024, 6, 16, 16, 41, 2, 695, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "MedicinNotes", "TimeEnd", "TimeStart" },
                values: new object[] { null, new DateTime(2024, 6, 16, 21, 41, 2, 695, DateTimeKind.Local).AddTicks(2093), new DateTime(2024, 6, 16, 19, 41, 2, 695, DateTimeKind.Local).AddTicks(2092) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicinNotes",
                table: "Assignments");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 18, 37, 43, 232, DateTimeKind.Local).AddTicks(3271), new DateTime(2024, 6, 13, 16, 37, 43, 232, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 19, 37, 43, 232, DateTimeKind.Local).AddTicks(3283), new DateTime(2024, 6, 13, 18, 37, 43, 232, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 13, 21, 37, 43, 232, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 6, 13, 19, 37, 43, 232, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 14, 1, 37, 43, 232, DateTimeKind.Local).AddTicks(3305), new DateTime(2024, 6, 13, 22, 37, 43, 232, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 14, 3, 37, 43, 232, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 6, 14, 1, 37, 43, 232, DateTimeKind.Local).AddTicks(3313) });
        }
    }
}
