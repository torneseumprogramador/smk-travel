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
    public class CompanhiaAeriasController : Controller
    {
        private readonly DbContexto _context;

        public CompanhiaAeriasController(DbContexto context)
        {
            _context = context;
        }

        // GET: CompanhiaAerias
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanhiaAerias.ToListAsync());
        }

        // GET: CompanhiaAerias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companhiaAeria = await _context.CompanhiaAerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companhiaAeria == null)
            {
                return NotFound();
            }

            return View(companhiaAeria);
        }

        // GET: CompanhiaAerias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanhiaAerias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome")] CompanhiaAeria companhiaAeria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companhiaAeria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companhiaAeria);
        }

        // GET: CompanhiaAerias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companhiaAeria = await _context.CompanhiaAerias.FindAsync(id);
            if (companhiaAeria == null)
            {
                return NotFound();
            }
            return View(companhiaAeria);
        }

        // POST: CompanhiaAerias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome")] CompanhiaAeria companhiaAeria)
        {
            if (id != companhiaAeria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companhiaAeria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanhiaAeriaExists(companhiaAeria.Id))
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
            return View(companhiaAeria);
        }

        // GET: CompanhiaAerias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companhiaAeria = await _context.CompanhiaAerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companhiaAeria == null)
            {
                return NotFound();
            }

            return View(companhiaAeria);
        }

        // POST: CompanhiaAerias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companhiaAeria = await _context.CompanhiaAerias.FindAsync(id);
            _context.CompanhiaAerias.Remove(companhiaAeria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanhiaAeriaExists(int id)
        {
            return _context.CompanhiaAerias.Any(e => e.Id == id);
        }
    }
}
