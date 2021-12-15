using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_Inventory.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        public string ItemDesc { get; set; }
        public int BrandID { get; set; }
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int LocationID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateChanged { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatePurchased { get; set; }
        public float Quantity { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? ListofCategories { get; set; }   
    }
}
