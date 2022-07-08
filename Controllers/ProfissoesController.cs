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
    public class ProfissoesController : Controller
    {
        private readonly DbContexto _context;

        public ProfissoesController(DbContexto context)
        {
            _context = context;
        }

        // GET: Profissoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Profissao.ToListAsync());
        }

        // GET: Profissoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissao = await _context.Profissao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profissao == null)
            {
                return NotFound();
            }

            return View(profissao);
        }

        // GET: Profissoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profissoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome")] Profissao profissao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profissao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profissao);
        }

        // GET: Profissoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissao = await _context.Profissao.FindAsync(id);
            if (profissao == null)
            {
                return NotFound();
            }
            return View(profissao);
        }

        // POST: Profissoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome")] Profissao profissao)
        {
            if (id != profissao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profissao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfissaoExists(profissao.Id))
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
            return View(profissao);
        }

        // GET: Profissoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissao = await _context.Profissao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profissao == null)
            {
                return NotFound();
            }

            return View(profissao);
        }

        // POST: Profissoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profissao = await _context.Profissao.FindAsync(id);
            _context.Profissao.Remove(profissao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfissaoExists(int id)
        {
            return _context.Profissao.Any(e => e.Id == id);
        }
    }
}
