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
    public class AlojamentosController : Controller
    {
        private readonly DbContexto _context;

        public AlojamentosController(DbContexto context)
        {
            _context = context;
        }

        // GET: Alojamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alojamentos.ToListAsync());
        }

        // GET: Alojamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alojamento = await _context.Alojamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alojamento == null)
            {
                return NotFound();
            }

            return View(alojamento);
        }

        // GET: Alojamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alojamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome,Morada,Responsavel")] Alojamento alojamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alojamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alojamento);
        }

        // GET: Alojamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alojamento = await _context.Alojamentos.FindAsync(id);
            if (alojamento == null)
            {
                return NotFound();
            }
            return View(alojamento);
        }

        // POST: Alojamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome,Morada,Responsavel")] Alojamento alojamento)
        {
            if (id != alojamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alojamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlojamentoExists(alojamento.Id))
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
            return View(alojamento);
        }

        // GET: Alojamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alojamento = await _context.Alojamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alojamento == null)
            {
                return NotFound();
            }

            return View(alojamento);
        }

        // POST: Alojamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alojamento = await _context.Alojamentos.FindAsync(id);
            _context.Alojamentos.Remove(alojamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlojamentoExists(int id)
        {
            return _context.Alojamentos.Any(e => e.Id == id);
        }
    }
}
