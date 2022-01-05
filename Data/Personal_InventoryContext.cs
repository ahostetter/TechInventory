using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personal_Inventory.Models;

namespace Personal_Inventory.Data
{
    public class Personal_InventoryContext : DbContext
    {
        public Personal_InventoryContext (DbContextOptions<Personal_InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Personal_Inventory.Models.Inventory> Inventory { get; set; }

        public DbSet<Personal_Inventory.Models.Category> Category { get; set; }

        public DbSet<Personal_Inventory.Models.InventoryView> InventoryView { get; set; }

        public DbSet<Personal_Inventory.Models.Brand> Brand { get; set; }

    }
}
