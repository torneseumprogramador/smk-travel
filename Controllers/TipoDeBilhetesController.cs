using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using smk_travel.Models;
using smk_travel.Servicos.Database;

namespace smk_travel.Controllers
{
    public class TipoDeBilhetesController : Controller
    {
        private readonly DbContexto _context;

        public TipoDeBilhetesController(DbContexto context)
        {
            _context = context;
        }

        // GET: TipoDeBilhetes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoDeBilhetes.ToListAsync());
        }

        // GET: TipoDeBilhetes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeBilhete = await _context.TipoDeBilhetes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDeBilhete == null)
            {
                return NotFound();
            }

            return View(tipoDeBilhete);
        }

        // GET: TipoDeBilhetes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoDeBilhetes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome")] TipoDeBilhete tipoDeBilhete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoDeBilhete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDeBilhete);
        }

        // GET: TipoDeBilhetes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeBilhete = await _context.TipoDeBilhetes.FindAsync(id);
            if (tipoDeBilhete == null)
            {
                return NotFound();
            }
            return View(tipoDeBilhete);
        }

        // POST: TipoDeBilhetes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome")] TipoDeBilhete tipoDeBilhete)
        {
            if (id != tipoDeBilhete.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDeBilhete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDeBilheteExists(tipoDeBilhete.Id))
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
            return View(tipoDeBilhete);
        }

        // GET: TipoDeBilhetes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeBilhete = await _context.TipoDeBilhetes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDeBilhete == null)
            {
                return NotFound();
            }

            return View(tipoDeBilhete);
        }

        // POST: TipoDeBilhetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoDeBilhete = await _context.TipoDeBilhetes.FindAsync(id);
            _context.TipoDeBilhetes.Remove(tipoDeBilhete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDeBilheteExists(int id)
        {
            return _context.TipoDeBilhetes.Any(e => e.Id == id);
        }
    }
}
