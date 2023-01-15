using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Info.Data;
using Info.Models;

namespace Info.Controllers
{
    public class FirmaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FirmaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Firma
        public async Task<IActionResult> Index()
        {
              return View(await _context.Firmy.ToListAsync());
        }

        // GET: Firma/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Firmy == null)
            {
                return NotFound();
            }

            var firma = await _context.Firmy
                .FirstOrDefaultAsync(m => m.IdFirmy == id);
            if (firma == null)
            {
                return NotFound();
            }

            return View(firma);
        }

        // GET: Firma/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Firma/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFirmy,Nazwa,PelnaNazwa,Miejscowosc,KodPocztowy,Ulica,Telefon,Mail")] Firma firma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(firma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(firma);
        }

        // GET: Firma/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Firmy == null)
            {
                return NotFound();
            }

            var firma = await _context.Firmy.FindAsync(id);
            if (firma == null)
            {
                return NotFound();
            }
            return View(firma);
        }

        // POST: Firma/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFirmy,Nazwa,PelnaNazwa,Miejscowosc,KodPocztowy,Ulica,Telefon,Mail")] Firma firma)
        {
            if (id != firma.IdFirmy)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(firma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FirmaExists(firma.IdFirmy))
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
            return View(firma);
        }

        // GET: Firma/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Firmy == null)
            {
                return NotFound();
            }

            var firma = await _context.Firmy
                .FirstOrDefaultAsync(m => m.IdFirmy == id);
            if (firma == null)
            {
                return NotFound();
            }

            return View(firma);
        }

        // POST: Firma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Firmy == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Firmy'  is null.");
            }
            var firma = await _context.Firmy.FindAsync(id);
            if (firma != null)
            {
                _context.Firmy.Remove(firma);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Wizytowka(int? id)
        {
            if (id == null || _context.Firmy == null)
            {
                return NotFound();
            }

            var firma = await _context.Firmy
                .FirstOrDefaultAsync(m => m.IdFirmy == id);
            if (firma == null)
            {
                return NotFound();
            }

            return View(firma);
        }
        private bool FirmaExists(int id)
        {
          return _context.Firmy.Any(e => e.IdFirmy == id);
        }
    }
}
