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
    public class CompanhiaAereasController : Controller
    {
        private readonly DbContexto _context;

        public CompanhiaAereasController(DbContexto context)
        {
            _context = context;
        }

        // GET: CompanhiaAereas
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanhiaAereas.ToListAsync());
        }

        // GET: CompanhiaAereas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CompanhiaAerea = await _context.CompanhiaAereas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (CompanhiaAerea == null)
            {
                return NotFound();
            }

            return View(CompanhiaAerea);
        }

        // GET: CompanhiaAereas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanhiaAereas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome")] CompanhiaAerea CompanhiaAerea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(CompanhiaAerea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(CompanhiaAerea);
        }

        // GET: CompanhiaAereas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CompanhiaAerea = await _context.CompanhiaAereas.FindAsync(id);
            if (CompanhiaAerea == null)
            {
                return NotFound();
            }
            return View(CompanhiaAerea);
        }

        // POST: CompanhiaAereas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome")] CompanhiaAerea CompanhiaAerea)
        {
            if (id != CompanhiaAerea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(CompanhiaAerea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanhiaAereaExists(CompanhiaAerea.Id))
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
            return View(CompanhiaAerea);
        }

        // GET: CompanhiaAereas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CompanhiaAerea = await _context.CompanhiaAereas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (CompanhiaAerea == null)
            {
                return NotFound();
            }

            return View(CompanhiaAerea);
        }

        // POST: CompanhiaAereas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var CompanhiaAerea = await _context.CompanhiaAereas.FindAsync(id);
            _context.CompanhiaAereas.Remove(CompanhiaAerea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanhiaAereaExists(int id)
        {
            return _context.CompanhiaAereas.Any(e => e.Id == id);
        }
    }
}
