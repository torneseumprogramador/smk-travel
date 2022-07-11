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
    public class FuncionariosController : Controller
    {
        private readonly DbContexto _context;

        public FuncionariosController(DbContexto context)
        {
            _context = context;
        }

        // GET: Funcionarios
        [Route("/Funcionarios")]
        public async Task<IActionResult> Index()
        {
            var dbContexto = _context.Funcionarios.Include(f => f.CentroDeCusto).Include(f => f.Departamento).Include(f => f.Entidade).Include(f => f.Profissao);
            return View(await dbContexto.ToListAsync());
        }

        // GET: Funcionarios/Details/5
        [Route("/Funcionarios/Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios
                .Include(f => f.CentroDeCusto)
                .Include(f => f.Departamento)
                .Include(f => f.Entidade)
                .Include(f => f.Profissao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // GET: Funcionarios/Create
        [Route("/Funcionarios/Create")]
        public IActionResult Create()
        {
            ViewData["CentroDeCustoId"] = new SelectList(_context.CentroDeCustos, "Id", "Nome");
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "Id", "Nome");
            ViewData["EntidadeId"] = new SelectList(_context.Entidades, "Id", "Nome");
            ViewData["ProfissaoId"] = new SelectList(_context.Set<Profissao>(), "Id", "Nome");
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Funcionarios/Create")]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Nome,DepartamentoId,CentroDeCustoId,EntidadeId,ProfissaoId")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CentroDeCustoId"] = new SelectList(_context.CentroDeCustos, "Id", "Codigo", funcionario.CentroDeCustoId);
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "Id", "Codigo", funcionario.DepartamentoId);
            ViewData["EntidadeId"] = new SelectList(_context.Entidades, "Id", "Codigo", funcionario.EntidadeId);
            ViewData["ProfissaoId"] = new SelectList(_context.Set<Profissao>(), "Id", "Codigo", funcionario.ProfissaoId);
            return View(funcionario);
        }

        // GET: Funcionarios/Edit/5
        [Route("/Funcionarios/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            ViewData["CentroDeCustoId"] = new SelectList(_context.CentroDeCustos, "Id", "Codigo", funcionario.CentroDeCustoId);
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "Id", "Codigo", funcionario.DepartamentoId);
            ViewData["EntidadeId"] = new SelectList(_context.Entidades, "Id", "Codigo", funcionario.EntidadeId);
            ViewData["ProfissaoId"] = new SelectList(_context.Set<Profissao>(), "Id", "Codigo", funcionario.ProfissaoId);
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Funcionarios/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome,DepartamentoId,CentroDeCustoId,EntidadeId,ProfissaoId")] Funcionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.Id))
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
            ViewData["CentroDeCustoId"] = new SelectList(_context.CentroDeCustos, "Id", "Codigo", funcionario.CentroDeCustoId);
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "Id", "Codigo", funcionario.DepartamentoId);
            ViewData["EntidadeId"] = new SelectList(_context.Entidades, "Id", "Codigo", funcionario.EntidadeId);
            ViewData["ProfissaoId"] = new SelectList(_context.Set<Profissao>(), "Id", "Codigo", funcionario.ProfissaoId);
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        [Route("/Funcionarios/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios
                .Include(f => f.CentroDeCusto)
                .Include(f => f.Departamento)
                .Include(f => f.Entidade)
                .Include(f => f.Profissao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("/Funcionarios/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioExists(int id)
        {
            return _context.Funcionarios.Any(e => e.Id == id);
        }
    }
}
