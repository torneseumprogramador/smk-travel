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
    public class ArquivoDeFuncionariosController : Controller
    {
        private readonly DbContexto _context;

        public ArquivoDeFuncionariosController(DbContexto context)
        {
            _context = context;
        }

        // GET: ArquivoDeFuncionarios
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/")]
        public async Task<IActionResult> Index([FromRoute] int funcionarioId)
        {
            var dbContexto = _context.ArquivoDeFuncionarios.Include(a => a.Funcionario);
            return View(await dbContexto.ToListAsync());
        }

        // GET: ArquivoDeFuncionarios/Details/5
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Details/{id}")]
        public async Task<IActionResult> Details([FromRoute] int funcionarioId, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arquivoDeFuncionario = await _context.ArquivoDeFuncionarios
                .Include(a => a.Funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arquivoDeFuncionario == null)
            {
                return NotFound();
            }

            return View(arquivoDeFuncionario);
        }

        // GET: ArquivoDeFuncionarios/Create
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Create")]
        public IActionResult Create([FromRoute] int funcionarioId)
        {
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo");
            return View();
        }

        // POST: ArquivoDeFuncionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Create")]
        public async Task<IActionResult> Create([FromRoute] int funcionarioId, [Bind("Id,Arquivo,FuncionarioId")] ArquivoDeFuncionario arquivoDeFuncionario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arquivoDeFuncionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo", arquivoDeFuncionario.FuncionarioId);
            return View(arquivoDeFuncionario);
        }

        // GET: ArquivoDeFuncionarios//5
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Edit/{id}")]
        public async Task<IActionResult> Edit([FromRoute] int funcionarioId, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arquivoDeFuncionario = await _context.ArquivoDeFuncionarios.FindAsync(id);
            if (arquivoDeFuncionario == null)
            {
                return NotFound();
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo", arquivoDeFuncionario.FuncionarioId);
            return View(arquivoDeFuncionario);
        }

        // POST: ArquivoDeFuncionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Edit/{id}")]
        public async Task<IActionResult> Edit([FromRoute] int funcionarioId, int id, [Bind("Id,Arquivo,FuncionarioId")] ArquivoDeFuncionario arquivoDeFuncionario)
        {
            if (id != arquivoDeFuncionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arquivoDeFuncionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArquivoDeFuncionarioExists(arquivoDeFuncionario.Id))
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
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo", arquivoDeFuncionario.FuncionarioId);
            return View(arquivoDeFuncionario);
        }

        // GET: ArquivoDeFuncionarios/Delete/5
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int funcionarioId, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arquivoDeFuncionario = await _context.ArquivoDeFuncionarios
                .Include(a => a.Funcionario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arquivoDeFuncionario == null)
            {
                return NotFound();
            }

            return View(arquivoDeFuncionario);
        }

        // POST: ArquivoDeFuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed([FromRoute] int funcionarioId, int id)
        {
            var arquivoDeFuncionario = await _context.ArquivoDeFuncionarios.FindAsync(id);
            _context.ArquivoDeFuncionarios.Remove(arquivoDeFuncionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArquivoDeFuncionarioExists(int id)
        {
            return _context.ArquivoDeFuncionarios.Any(e => e.Id == id);
        }
    }
}
