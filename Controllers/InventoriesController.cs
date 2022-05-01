using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Personal_Inventory.Data;
using Personal_Inventory.Models;

namespace Personal_Inventory.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly Personal_InventoryContext _context;

        public InventoriesController(Personal_InventoryContext context)
        {
            _context = context;
        }

        // GET: Inventories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inventory.ToListAsync());
        }

        // GET: Inventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory
                .FirstOrDefaultAsync(m => m.ID == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        public IActionResult Create()
        {
            //Populate DropDownList binding values
            var model = new Inventory
            {
                ItemDesc = null,
                ListofBrands = _context.Brand.Select(c => new SelectListItem
                {
                    Value = c.ID.ToString(),
                    Text = c.BrandName
                }),
                ListofCategories = _context.Category.Select(c => new SelectListItem
                {
                    Value = c.ID.ToString(),
                    Text = c.CategoryName
                }),
                //Needs to connect to selected Category by user: 1 is just a test.
                ListofSubCategories = _context.SubCategory.Where(x => x.CategoryId == 1).Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.SubCategoryName
                }),
                //SubCategoryID = 0,
                LocationID = 0,
                DateEntered = DateTime.Now,
                DateChanged = DateTime.Now,
                DatePurchased = DateTime.Now,
                Quantity = 0
            };
            return View(model);
        }


        //// GET: Inventories/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Inventories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ItemDesc,BrandID,CategoryID,SubCategoryID,LocationID,DateEntered,DateChanged,DatePurchased,Quantity")] Inventory newInventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newInventory);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "InventoriesView");
            }
            return View(newInventory);
        }

        // GET: Inventories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return View(inventory);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ItemDesc,BrandID,CategoryID,SubCategoryID,LocationID,DateEntered,DateChanged,DatePurchased,Quantity")] Inventory inventory)
        {
            if (id != inventory.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryExists(inventory.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(inventory);
        }

        // GET: Inventories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory
                .FirstOrDefaultAsync(m => m.ID == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // POST: Inventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventory = await _context.Inventory.FindAsync(id);
            _context.Inventory.Remove(inventory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryExists(int id)
        {
            return _context.Inventory.Any(e => e.ID == id);
        }
    }
}
