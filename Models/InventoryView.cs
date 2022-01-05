using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_Inventory.Models
{
    public class InventoryView
    {
        public int ID { get; set; }
        public string? ItemDesc { get; set; }
        [Display(Name = "Brand")]
        public string? BrandName { get; set; }
        [Display(Name = "Category")]
        public string? CategoryName { get; set; }
        public int SubCategoryID { get; set; }
        public int LocationID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateChanged { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatePurchased { get; set; }
        public float Quantity { get; set; }
    }
}
