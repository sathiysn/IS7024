using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthWatch360.Migrations
{
    /// <inheritdoc />
    public partial class directors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicationTracker");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "NutritionLog");

            migrationBuilder.DropColumn(
                name: "Carbohydrates",
                table: "NutritionLog");

            migrationBuilder.DropColumn(
                name: "Fats",
                table: "NutritionLog");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "NutritionLog");

            migrationBuilder.DropColumn(
                name: "Proteins",
                table: "NutritionLog");

            migrationBuilder.DropColumn(
                name: "Sodium",
                table: "NutritionLog");

            migrationBuilder.DropColumn(
                name: "Sugar",
                table: "NutritionLog");

            migrationBuilder.RenameColumn(
                name: "NutritionLogID",
                table: "NutritionLog",
                newName: "NutritionLogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NutritionLogId",
                table: "NutritionLog",
                newName: "NutritionLogID");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "NutritionLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Carbohydrates",
                table: "NutritionLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fats",
                table: "NutritionLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fiber",
                table: "NutritionLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Proteins",
                table: "NutritionLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sodium",
                table: "NutritionLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sugar",
                table: "NutritionLog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MedicationTracker",
                columns: table => new
                {
                    MedicationTrackerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    Dosage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReminderTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TakenStatus = table.Column<bool>(type: "bit", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_MedicationTracker_UserID",
                table: "MedicationTracker",
                column: "UserID");
        }
    }
}
