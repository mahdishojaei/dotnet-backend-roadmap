using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsvToSqlImporter.Migrations
{
    /// <inheritdoc />
    public partial class RenameTemperatureColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "SensorRecords",
                newName: "Temp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temp",
                table: "SensorRecords",
                newName: "Temperature");
        }
    }
}
