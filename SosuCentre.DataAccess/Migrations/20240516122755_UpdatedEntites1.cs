using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntites1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "City", "State", "Street", "ZipCode" },
                values: new object[] { 1, "Vejle", "Midt Jylland", "Boulevarden 31", "7100" });

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
                table: "CareCenters",
                columns: new[] { "CareCenterId", "AddressId", "Name" },
                values: new object[] { 1, 1, "SosuCenter Vejle" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1);

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
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1);
        }
    }
}
