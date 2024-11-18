using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthWatch360.Migrations
{
    /// <inheritdoc />
    public partial class users_error_messages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "HealthReport");

            migrationBuilder.DropColumn(
                name: "GoalSummary",
                table: "HealthReport");

            migrationBuilder.DropColumn(
                name: "HealthDataSummary",
                table: "HealthReport");

            migrationBuilder.DropColumn(
                name: "RecommmendationSummary",
                table: "HealthReport");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "HealthReport");

            migrationBuilder.DropColumn(
                name: "CaloriesBurned",
                table: "ExerciseLog");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ExerciseLog");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ExerciseLog");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ExerciseLog");

            migrationBuilder.RenameColumn(
                name: "HealthReportID",
                table: "HealthReport",
                newName: "HealthReportId");

            migrationBuilder.RenameColumn(
                name: "ExerciseLogID",
                table: "ExerciseLog",
                newName: "ExerciseLogId");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "User",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "User",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HealthReportId",
                table: "HealthReport",
                newName: "HealthReportID");

            migrationBuilder.RenameColumn(
                name: "ExerciseLogId",
                table: "ExerciseLog",
                newName: "ExerciseLogID");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "HealthReport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoalSummary",
                table: "HealthReport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthDataSummary",
                table: "HealthReport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecommmendationSummary",
                table: "HealthReport",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "HealthReport",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaloriesBurned",
                table: "ExerciseLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ExerciseLog",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Duration",
                table: "ExerciseLog",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ExerciseLog",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
