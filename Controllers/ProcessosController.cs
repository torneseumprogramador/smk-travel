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
    public class ProcessosController : Controller
    {
        private readonly DbContexto _context;

        public ProcessosController(DbContexto context)
        {
            _context = context;
        }

        // GET: Processos
        public async Task<IActionResult> Index()
        {
            var dbContexto = _context.Processos.Include(p => p.Funcionario).Include(p => p.Itinerario).Include(p => p.Motivo).Include(p => p.Site);
            return View(await dbContexto.ToListAsync());
        }

        // GET: Processos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos
                .Include(p => p.Funcionario)
                .Include(p => p.Itinerario)
                .Include(p => p.Motivo)
                .Include(p => p.Site)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // GET: Processos/Create
        public IActionResult Create()
        {
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome");
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Nome");
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Nome");
            ViewData["SiteId"] = new SelectList(_context.Sites, "Id", "Nome");
            return View();
        }

        // POST: Processos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FuncionarioId,ItinerarioId,SiteId,DataSaida,DataChagada,MotivoId,TesteCovid,Comentarios,DiasDeTrabalho,Data,DataSolicitacaoInicio,DataSolicitacaoFim,DataCriacao,DataAtualizacao")] Processo processo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(processo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", processo.FuncionarioId);
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Nome", processo.ItinerarioId);
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Nome", processo.MotivoId);
            ViewData["SiteId"] = new SelectList(_context.Sites, "Id", "Nome", processo.SiteId);
            return View(processo);
        }

        // GET: Processos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos.FindAsync(id);
            if (processo == null)
            {
                return NotFound();
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", processo.FuncionarioId);
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Nome", processo.ItinerarioId);
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Nome", processo.MotivoId);
            ViewData["SiteId"] = new SelectList(_context.Sites, "Id", "Nome", processo.SiteId);
            return View(processo);
        }

        // POST: Processos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FuncionarioId,ItinerarioId,SiteId,DataSaida,DataChagada,MotivoId,TesteCovid,Comentarios,DiasDeTrabalho,Data,DataSolicitacaoInicio,DataSolicitacaoFim,DataCriacao,DataAtualizacao")] Processo processo)
        {
            if (id != processo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(processo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessoExists(processo.Id))
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
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Nome", processo.FuncionarioId);
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Nome", processo.ItinerarioId);
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Nome", processo.MotivoId);
            ViewData["SiteId"] = new SelectList(_context.Sites, "Id", "Nome", processo.SiteId);
            return View(processo);
        }

        // GET: Processos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos
                .Include(p => p.Funcionario)
                .Include(p => p.Itinerario)
                .Include(p => p.Motivo)
                .Include(p => p.Site)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // POST: Processos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var processo = await _context.Processos.FindAsync(id);
            _context.Processos.Remove(processo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessoExists(int id)
        {
            return _context.Processos.Any(e => e.Id == id);
        }
    }
}
