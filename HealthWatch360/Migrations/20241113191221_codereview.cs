using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthWatch360.Migrations
{
    /// <inheritdoc />
    public partial class codereview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseLog",
                columns: table => new
                {
                    ExerciseLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CaloriesBurned = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseLog", x => x.ExerciseLogID);
                    table.ForeignKey(
                        name: "FK_ExerciseLog_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    GoalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetValue = table.Column<int>(type: "int", nullable: true),
                    CurrentValue = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.GoalID);
                    table.ForeignKey(
                        name: "FK_Goal_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "MedicationTracker",
                columns: table => new
                {
                    MedicationTrackerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TakenStatus = table.Column<bool>(type: "bit", nullable: true),
                    ReminderTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationTracker", x => x.MedicationTrackerID);
                    table.ForeignKey(
                        name: "FK_MedicationTracker_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "NutritionLog",
                columns: table => new
                {
                    NutritionLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories = table.Column<int>(type: "int", nullable: true),
                    Carbohydrates = table.Column<int>(type: "int", nullable: true),
                    Proteins = table.Column<int>(type: "int", nullable: true),
                    Fats = table.Column<int>(type: "int", nullable: true),
                    Fiber = table.Column<int>(type: "int", nullable: true),
                    Sugar = table.Column<int>(type: "int", nullable: true),
                    Sodium = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionLog", x => x.NutritionLogID);
                    table.ForeignKey(
                        name: "FK_NutritionLog_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseLog_UserID",
                table: "ExerciseLog",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Goal_UserID",
                table: "Goal",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationTracker_UserID",
                table: "MedicationTracker",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionLog_UserID",
                table: "NutritionLog",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseLog");

            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropTable(
                name: "MedicationTracker");

            migrationBuilder.DropTable(
                name: "NutritionLog");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
