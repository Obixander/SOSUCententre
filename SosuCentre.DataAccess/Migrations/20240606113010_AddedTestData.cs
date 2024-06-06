using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "City", "State", "Street", "ZipCode" },
                values: new object[] { 1, "Vejle", "Syd Jylland", "Boulevarden 31", "7100" });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "DiagnosisId", "Description", "Name", "ResidentId" },
                values: new object[,]
                {
                    { 1, "Alzheimer er en sygdom, der angriber hjernen og fører til en gradvis nedbrydning af hukommelse, tænkning og evnen til at udføre daglige opgaver.", "Alzheimer", null },
                    { 2, "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen. Symptomerne kan være problemer med hukommelsen, sprog, orientering og erkendelse.", "Demens", null },
                    { 3, "Parkinsons sygdom er en kronisk sygdom, der skyldes en gradvis nedbrydning af hjerneceller, der producerer signalstoffet dopamin. Sygdommen medfører langsomme bevægelser, stivhed og rysten.", "Parkinson", null }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "Name" },
                values: new object[,]
                {
                    { 1, "Tyrol" },
                    { 2, "Paracetamol" },
                    { 3, "Ibuprofen" },
                    { 4, "Aspirin" },
                    { 5, "Amoxicillin" },
                    { 6, "Ciprofloxacin" },
                    { 7, "Metformin" },
                    { 8, "Lisinopril" },
                    { 9, "Simvastatin" },
                    { 10, "Omeprazole" }
                });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "MedicineTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[] { -1, null, false, null });

            migrationBuilder.InsertData(
                table: "CareCenters",
                columns: new[] { "CareCenterId", "AddressId", "Name" },
                values: new object[] { 1, 1, "SosuCenter Vejle" });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicinAssignmentId", "MedicineId", "Unit" },
                values: new object[] { -1, 2, null, 1, "dl" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CareCenterId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "John Smith" },
                    { 2, 1, "Chris William" },
                    { 3, 1, "simon lastname" },
                    { 4, 1, "John Doe" },
                    { 5, 1, "Jane Simons" }
                });

            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "CareCenterId", "Name", "Notes", "RoomNumber" },
                values: new object[,]
                {
                    { 1, 1, "Mads Mikkel", "HE Suck big fat", "32" },
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
                table: "Assignment",
                columns: new[] { "AssignmentId", "Completed", "Notes", "ResidentId", "TimeEnd", "TimeStart" },
                values: new object[] { 1, false, "Husk at give vand med medicinet", 1, new DateTime(2024, 6, 6, 15, 30, 10, 407, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 6, 6, 13, 30, 10, 407, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "MedicineTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[] { 1, 1, false, "Giv vand" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MedicineTasks",
                keyColumn: "MedicineTaskId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 10);

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

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "MedicineTaskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "MedicineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "MedicineTaskId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1);
        }
    }
}
