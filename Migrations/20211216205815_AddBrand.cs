using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personal_Inventory.Migrations
{
    public partial class AddBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW [dbo].[InventoryView] AS SELECT I.ID, I.ItemDesc, B.BrandName, C.CategoryName, I.SubCategoryID, I.LocationID, I.DateEntered, I.DateChanged, I.DatePurchased, I.Quantity 
            FROM dbo.Inventory AS I 
            INNER JOIN dbo.Category AS C ON I.CategoryID = C.ID
            INNER JOIN dbo.Brand AS B ON I.BrandID = B.ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view InventoryView");
        }
    }
}
