using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PantryOnline.Models;

namespace PantryOnline.Controllers
{
    public class PantriesController : Controller
    {
        private readonly PantryOnlineContext _context;

        public PantriesController(PantryOnlineContext context)
        {
            _context = context;
        }

        // GET: Pantries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pantry.ToListAsync());
        }

        // GET: Pantries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantry = await _context.Pantry
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pantry == null)
            {
                return NotFound();
            }

            return View(pantry);
        }

        // GET: Pantries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pantries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Pantry pantry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pantry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pantry);
        }

        // GET: Pantries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantry = await _context.Pantry.FindAsync(id);
            if (pantry == null)
            {
                return NotFound();
            }
            return View(pantry);
        }

        // POST: Pantries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Pantry pantry)
        {
            if (id != pantry.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pantry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PantryExists(pantry.ID))
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
            return View(pantry);
        }

        // GET: Pantries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantry = await _context.Pantry
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pantry == null)
            {
                return NotFound();
            }

            return View(pantry);
        }

        // POST: Pantries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pantry = await _context.Pantry.FindAsync(id);
            _context.Pantry.Remove(pantry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PantryExists(int id)
        {
            return _context.Pantry.Any(e => e.ID == id);
        }
    }
}
