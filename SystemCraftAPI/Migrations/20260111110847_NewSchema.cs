using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemCraftAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Webcams");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Mice");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Headphones");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Computers");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Webcams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Printers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Monitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Mice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Laptops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Keyboards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Headphones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Computers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            // Seed a default brand and backfill existing rows to avoid FK conflicts
            migrationBuilder.Sql(@"SET IDENTITY_INSERT Brands ON;
IF NOT EXISTS (SELECT 1 FROM Brands WHERE Id = 1)
BEGIN
    INSERT INTO Brands (Id, Name, Country, Website) VALUES (1, 'Default Brand', 'N/A', '');
END
SET IDENTITY_INSERT Brands OFF;");

            migrationBuilder.Sql("UPDATE Computers SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Laptops SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Monitors SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Keyboards SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Mice SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Printers SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Headphones SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE GraphicsCards SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");
            migrationBuilder.Sql("UPDATE Webcams SET BrandId = 1 WHERE BrandId NOT IN (SELECT Id FROM Brands) OR BrandId IS NULL");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserComputerFavorites",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ComputerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComputerFavorites", x => new { x.UserId, x.ComputerId });
                    table.ForeignKey(
                        name: "FK_UserComputerFavorites_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComputerFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserHeadphonesFavorites",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    HeadphonesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHeadphonesFavorites", x => new { x.UserId, x.HeadphonesId });
                    table.ForeignKey(
                        name: "FK_UserHeadphonesFavorites_Headphones_HeadphonesId",
                        column: x => x.HeadphonesId,
                        principalTable: "Headphones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHeadphonesFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLaptopFavorites",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LaptopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLaptopFavorites", x => new { x.UserId, x.LaptopId });
                    table.ForeignKey(
                        name: "FK_UserLaptopFavorites_Laptops_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Laptops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLaptopFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMonitorFavorites",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MonitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMonitorFavorites", x => new { x.UserId, x.MonitorId });
                    table.ForeignKey(
                        name: "FK_UserMonitorFavorites_Monitors_MonitorId",
                        column: x => x.MonitorId,
                        principalTable: "Monitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMonitorFavorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Webcams_BrandId",
                table: "Webcams",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_BrandId",
                table: "Printers",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_BrandId",
                table: "Monitors",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Mice_BrandId",
                table: "Mice",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Laptops_BrandId",
                table: "Laptops",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_BrandId",
                table: "Keyboards",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Headphones_BrandId",
                table: "Headphones",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_GraphicsCards_BrandId",
                table: "GraphicsCards",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_BrandId",
                table: "Computers",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComputerFavorites_ComputerId",
                table: "UserComputerFavorites",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHeadphonesFavorites_HeadphonesId",
                table: "UserHeadphonesFavorites",
                column: "HeadphonesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLaptopFavorites_LaptopId",
                table: "UserLaptopFavorites",
                column: "LaptopId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMonitorFavorites_MonitorId",
                table: "UserMonitorFavorites",
                column: "MonitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Computers_Brands_BrandId",
                table: "Computers",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GraphicsCards_Brands_BrandId",
                table: "GraphicsCards",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Headphones_Brands_BrandId",
                table: "Headphones",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Keyboards_Brands_BrandId",
                table: "Keyboards",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Laptops_Brands_BrandId",
                table: "Laptops",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mice_Brands_BrandId",
                table: "Mice",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_Brands_BrandId",
                table: "Monitors",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_Brands_BrandId",
                table: "Printers",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Webcams_Brands_BrandId",
                table: "Webcams",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computers_Brands_BrandId",
                table: "Computers");

            migrationBuilder.DropForeignKey(
                name: "FK_GraphicsCards_Brands_BrandId",
                table: "GraphicsCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Headphones_Brands_BrandId",
                table: "Headphones");

            migrationBuilder.DropForeignKey(
                name: "FK_Keyboards_Brands_BrandId",
                table: "Keyboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Laptops_Brands_BrandId",
                table: "Laptops");

            migrationBuilder.DropForeignKey(
                name: "FK_Mice_Brands_BrandId",
                table: "Mice");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_Brands_BrandId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_Brands_BrandId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_Webcams_Brands_BrandId",
                table: "Webcams");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "UserComputerFavorites");

            migrationBuilder.DropTable(
                name: "UserHeadphonesFavorites");

            migrationBuilder.DropTable(
                name: "UserLaptopFavorites");

            migrationBuilder.DropTable(
                name: "UserMonitorFavorites");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Webcams_BrandId",
                table: "Webcams");

            migrationBuilder.DropIndex(
                name: "IX_Printers_BrandId",
                table: "Printers");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_BrandId",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Mice_BrandId",
                table: "Mice");

            migrationBuilder.DropIndex(
                name: "IX_Laptops_BrandId",
                table: "Laptops");

            migrationBuilder.DropIndex(
                name: "IX_Keyboards_BrandId",
                table: "Keyboards");

            migrationBuilder.DropIndex(
                name: "IX_Headphones_BrandId",
                table: "Headphones");

            migrationBuilder.DropIndex(
                name: "IX_GraphicsCards_BrandId",
                table: "GraphicsCards");

            migrationBuilder.DropIndex(
                name: "IX_Computers_BrandId",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Webcams");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Mice");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Keyboards");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Headphones");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Computers");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Webcams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Printers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Monitors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Mice",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Laptops",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Keyboards",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Headphones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "GraphicsCards",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Computers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
