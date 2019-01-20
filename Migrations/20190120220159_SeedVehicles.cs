using Microsoft.EntityFrameworkCore.Migrations;

namespace cardealer.Migrations
{
	public partial class SeedVehicles : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql($"INSERT INTO Vehicles (ContactName, ContactPhone, LastUpdated, ModelId) VALUES ('John Smith', '017271234567',  CURRENT_TIMESTAMP, (SELECT ID FROM Models WHERE Name = 'Make1-ModelA'))".ToString());
			migrationBuilder.Sql($"INSERT INTO Vehicles (ContactName, ContactPhone, LastUpdated, ModelId) VALUES ('George Lawrence', '017277654321', CURRENT_TIMESTAMP, (SELECT ID FROM Models WHERE Name = 'Make2-ModelB'))");
			migrationBuilder.Sql($"INSERT INTO Vehicles (ContactName, ContactPhone, LastUpdated, ModelId) VALUES ('Sarah Taylor', '017271122334', CURRENT_TIMESTAMP, (SELECT ID FROM Models WHERE Name = 'Make3-Modelc'))");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("DELETE FROM Vehicles WHERE ContactName IN ('John Smith', 'George Lawrence', 'Sarah Taylor')");
		}
	}
}
