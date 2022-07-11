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
    public class SituacaoViagensController : Controller
    {
        private readonly DbContexto _context;

        public SituacaoViagensController(DbContexto context)
        {
            _context = context;
        }

        // GET: SituacaoViagens
        public async Task<IActionResult> Index()
        {
            var dbContexto = _context.SituacaoViagens.Include(s => s.Viagem);
            return View(await dbContexto.ToListAsync());
        }

        // GET: SituacaoViagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var situacaoViagem = await _context.SituacaoViagens
                .Include(s => s.Viagem)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (situacaoViagem == null)
            {
                return NotFound();
            }

            return View(situacaoViagem);
        }

        // GET: SituacaoViagens/Create
        public IActionResult Create()
        {
            ViewData["ViagemId"] = new SelectList(_context.Viagens, "Id", "Arquivo");
            return View();
        }

        // POST: SituacaoViagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ViagemId,Situacao,Data")] SituacaoViagem situacaoViagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(situacaoViagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ViagemId"] = new SelectList(_context.Viagens, "Id", "Arquivo", situacaoViagem.ViagemId);
            return View(situacaoViagem);
        }

        // GET: SituacaoViagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var situacaoViagem = await _context.SituacaoViagens.FindAsync(id);
            if (situacaoViagem == null)
            {
                return NotFound();
            }
            ViewData["ViagemId"] = new SelectList(_context.Viagens, "Id", "Arquivo", situacaoViagem.ViagemId);
            return View(situacaoViagem);
        }

        // POST: SituacaoViagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ViagemId,Situacao,Data")] SituacaoViagem situacaoViagem)
        {
            if (id != situacaoViagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(situacaoViagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SituacaoViagemExists(situacaoViagem.Id))
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
            ViewData["ViagemId"] = new SelectList(_context.Viagens, "Id", "Arquivo", situacaoViagem.ViagemId);
            return View(situacaoViagem);
        }

        // GET: SituacaoViagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var situacaoViagem = await _context.SituacaoViagens
                .Include(s => s.Viagem)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (situacaoViagem == null)
            {
                return NotFound();
            }

            return View(situacaoViagem);
        }

        // POST: SituacaoViagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var situacaoViagem = await _context.SituacaoViagens.FindAsync(id);
            _context.SituacaoViagens.Remove(situacaoViagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SituacaoViagemExists(int id)
        {
            return _context.SituacaoViagens.Any(e => e.Id == id);
        }
    }
}
