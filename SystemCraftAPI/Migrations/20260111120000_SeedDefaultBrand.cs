using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemCraftAPI.Migrations
{
    public partial class SeedDefaultBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Ensure a default brand exists
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM Brands WHERE Id = 1)
BEGIN
    INSERT INTO Brands (Id, Name, Country, Website)
    VALUES (1, 'Default Brand', 'N/A', '');
END
");

            // Point any orphaned product rows to the default brand
            migrationBuilder.Sql("UPDATE Computers SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Laptops SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Monitors SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Keyboards SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Mice SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Printers SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Headphones SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE GraphicsCards SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Webcams SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Optionally clean the default brand if it exists
            migrationBuilder.Sql("DELETE FROM Brands WHERE Id = 1 AND Name = 'Default Brand'");
        }
    }
}
