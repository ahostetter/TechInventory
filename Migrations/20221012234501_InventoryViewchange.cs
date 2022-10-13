using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personal_Inventory.Migrations
{
    public partial class InventoryViewchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW [dbo].[InventoryView] AS SELECT I.ID, I.ItemDesc, B.BrandName, C.CategoryName, S.SubCategoryName, I.LocationID, I.DateEntered, I.DateChanged, I.DatePurchased, I.Quantity 
            FROM dbo.Inventory AS I 
            INNER JOIN dbo.Category AS C ON I.CategoryID = C.ID
            INNER JOIN dbo.Brand AS B ON I.BrandID = B.ID
            INNER JOIN dbo.SubCategory AS S ON C.ID = S.CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view InventoryView");
        }
    }
}
