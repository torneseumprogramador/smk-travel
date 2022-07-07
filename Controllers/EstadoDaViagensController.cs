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
    public class EstadoDaViagensController : Controller
    {
        private readonly DbContexto _context;

        public EstadoDaViagensController(DbContexto context)
        {
            _context = context;
        }

        // GET: EstadoDaViagens
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadoDaViagens.ToListAsync());
        }

        // GET: EstadoDaViagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDaViagem = await _context.EstadoDaViagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadoDaViagem == null)
            {
                return NotFound();
            }

            return View(estadoDaViagem);
        }

        // GET: EstadoDaViagens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoDaViagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome")] EstadoDaViagem estadoDaViagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoDaViagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadoDaViagem);
        }

        // GET: EstadoDaViagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDaViagem = await _context.EstadoDaViagens.FindAsync(id);
            if (estadoDaViagem == null)
            {
                return NotFound();
            }
            return View(estadoDaViagem);
        }

        // POST: EstadoDaViagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome")] EstadoDaViagem estadoDaViagem)
        {
            if (id != estadoDaViagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoDaViagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoDaViagemExists(estadoDaViagem.Id))
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
            return View(estadoDaViagem);
        }

        // GET: EstadoDaViagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDaViagem = await _context.EstadoDaViagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadoDaViagem == null)
            {
                return NotFound();
            }

            return View(estadoDaViagem);
        }

        // POST: EstadoDaViagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estadoDaViagem = await _context.EstadoDaViagens.FindAsync(id);
            _context.EstadoDaViagens.Remove(estadoDaViagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoDaViagemExists(int id)
        {
            return _context.EstadoDaViagens.Any(e => e.Id == id);
        }
    }
}
