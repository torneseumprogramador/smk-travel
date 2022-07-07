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
    public class MotivosController : Controller
    {
        private readonly DbContexto _context;

        public MotivosController(DbContexto context)
        {
            _context = context;
        }

        // GET: Motivos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Motivos.ToListAsync());
        }

        // GET: Motivos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motivo = await _context.Motivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motivo == null)
            {
                return NotFound();
            }

            return View(motivo);
        }

        // GET: Motivos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motivos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome")] Motivo motivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motivo);
        }

        // GET: Motivos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motivo = await _context.Motivos.FindAsync(id);
            if (motivo == null)
            {
                return NotFound();
            }
            return View(motivo);
        }

        // POST: Motivos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome")] Motivo motivo)
        {
            if (id != motivo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotivoExists(motivo.Id))
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
            return View(motivo);
        }

        // GET: Motivos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motivo = await _context.Motivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motivo == null)
            {
                return NotFound();
            }

            return View(motivo);
        }

        // POST: Motivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motivo = await _context.Motivos.FindAsync(id);
            _context.Motivos.Remove(motivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotivoExists(int id)
        {
            return _context.Motivos.Any(e => e.Id == id);
        }
    }
}
