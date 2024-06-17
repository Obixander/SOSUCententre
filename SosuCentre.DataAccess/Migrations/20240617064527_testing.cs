using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SosuCentre.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.MedicineId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "CareCenters",
                columns: table => new
                {
                    CareCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareCenters", x => x.CareCenterId);
                    table.ForeignKey(
                        name: "FK_CareCenters_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareCenterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_CareCenters_CareCenterId",
                        column: x => x.CareCenterId,
                        principalTable: "CareCenters",
                        principalColumn: "CareCenterId");
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    ResidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareCenterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.ResidentId);
                    table.ForeignKey(
                        name: "FK_Residents_CareCenters_CareCenterId",
                        column: x => x.CareCenterId,
                        principalTable: "CareCenters",
                        principalColumn: "CareCenterId");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRole",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRole", x => new { x.EmployeesEmployeeId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResidentId = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicinNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                    table.ForeignKey(
                        name: "FK_Assignments_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId");
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    DiagnosisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.DiagnosisId);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId");
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    PrescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.PrescriptionId);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId");
                });

            migrationBuilder.CreateTable(
                name: "AssignmentEmployee",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    TasksAssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentEmployee", x => new { x.EmployeesEmployeeId, x.TasksAssignmentId });
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Assignments_TasksAssignmentId",
                        column: x => x.TasksAssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicineTasks",
                columns: table => new
                {
                    MedicineTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicineAssignmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineTasks", x => x.MedicineTaskId);
                    table.ForeignKey(
                        name: "FK_MedicineTasks_Assignments_MedicineAssignmentId",
                        column: x => x.MedicineAssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId");
                    table.ForeignKey(
                        name: "FK_MedicineTasks_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "MedicineId");
                });

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    SubTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.SubTaskId);
                    table.ForeignKey(
                        name: "FK_SubTasks_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId");
                });

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
                table: "CareCenters",
                columns: new[] { "CareCenterId", "AddressId", "Name" },
                values: new object[] { 1, 1, "SosuCenter Vejle" });

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
                table: "Assignments",
                columns: new[] { "AssignmentId", "Completed", "MedicinNotes", "Notes", "ResidentId", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, false, null, "PlaceHolder", 1, new DateTime(2024, 6, 17, 10, 45, 26, 930, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 6, 17, 8, 45, 26, 930, DateTimeKind.Local).AddTicks(6027) },
                    { 2, false, null, "PlaceHolder", 1, new DateTime(2024, 6, 17, 11, 45, 26, 930, DateTimeKind.Local).AddTicks(6095), new DateTime(2024, 6, 17, 10, 45, 26, 930, DateTimeKind.Local).AddTicks(6093) },
                    { 3, false, null, "PlaceHolder", 1, new DateTime(2024, 6, 17, 13, 45, 26, 930, DateTimeKind.Local).AddTicks(6111), new DateTime(2024, 6, 17, 11, 45, 26, 930, DateTimeKind.Local).AddTicks(6110) },
                    { 4, false, null, "PlaceHolder", 1, new DateTime(2024, 6, 17, 17, 45, 26, 930, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 6, 17, 14, 45, 26, 930, DateTimeKind.Local).AddTicks(6125) },
                    { 5, false, null, "PlaceHolder", 1, new DateTime(2024, 6, 17, 19, 45, 26, 930, DateTimeKind.Local).AddTicks(6142), new DateTime(2024, 6, 17, 17, 45, 26, 930, DateTimeKind.Local).AddTicks(6140) }
                });

            migrationBuilder.InsertData(
                table: "MedicineTasks",
                columns: new[] { "MedicineTaskId", "Amount", "MedicineAssignmentId", "IsCompleted", "MedicineId", "Name", "Unit" },
                values: new object[,]
                {
                    { 1, 2.0, 1, false, 7, "PlaceHolder", "dl" },
                    { 2, 1.0, 1, false, 3, "PlaceHolder", "tablet" },
                    { 3, 5.0, 1, false, 9, "PlaceHolder", "ml" },
                    { 4, 2.5, 1, false, 2, "PlaceHolder", "g" },
                    { 5, 10.0, 1, false, 10, "PlaceHolder", "mg" },
                    { 6, 20.0, 2, false, 1, "PlaceHolder", "ml" },
                    { 7, 0.5, 2, false, 6, "PlaceHolder", "l" },
                    { 8, 15.0, 3, false, 8, "PlaceHolder", "units" },
                    { 9, 1.5, 3, false, 4, "PlaceHolder", "teaspoon" },
                    { 10, 3.0, 3, false, 5, "PlaceHolder", "tablespoon" },
                    { 11, 30.0, 4, false, 2, "PlaceHolder", "ml" },
                    { 12, 50.0, 4, false, 7, "PlaceHolder", "mg" },
                    { 13, 4.0, 4, false, 3, "PlaceHolder", "capsules" },
                    { 14, 0.25, 5, false, 1, "PlaceHolder", "liters" },
                    { 15, 75.0, 5, false, 5, "PlaceHolder", "units" }
                });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "SubTaskId", "AssignmentId", "IsCompleted", "Name" },
                values: new object[,]
                {
                    { 1, 1, false, "Giv vand" },
                    { 2, 1, false, "Hjælp med medicin" },
                    { 3, 1, false, "Planlægning af måltider" },
                    { 4, 1, false, "Overvågning af helbred" },
                    { 5, 2, false, "Transport til aftaler" },
                    { 6, 2, false, "Rengøring" },
                    { 7, 3, false, "Indkøb" },
                    { 8, 3, false, "Social kontakt" },
                    { 9, 3, false, "Assistance med daglig pleje" },
                    { 10, 4, false, "Hjælp med regninger" },
                    { 11, 4, false, "Planlægning af aktiviteter" },
                    { 12, 4, false, "Hjælp med teknologi" },
                    { 13, 5, false, "Følelsesmæssig støtte" },
                    { 14, 5, false, "Koordinering med sundhedstjenester" },
                    { 15, 5, false, "Støtte til mobilitet" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentEmployee_TasksAssignmentId",
                table: "AssignmentEmployee",
                column: "TasksAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ResidentId",
                table: "Assignments",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_CareCenters_AddressId",
                table: "CareCenters",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_ResidentId",
                table: "Diagnoses",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_RoleId",
                table: "EmployeeRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CareCenterId",
                table: "Employees",
                column: "CareCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_MedicineAssignmentId",
                table: "MedicineTasks",
                column: "MedicineAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_MedicineId",
                table: "MedicineTasks",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_ResidentId",
                table: "Prescriptions",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_CareCenterId",
                table: "Residents",
                column: "CareCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_AssignmentId",
                table: "SubTasks",
                column: "AssignmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentEmployee");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "EmployeeRole");

            migrationBuilder.DropTable(
                name: "MedicineTasks");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "CareCenters");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
