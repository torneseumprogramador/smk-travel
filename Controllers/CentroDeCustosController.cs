using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using smk_travel.Servicos.Database;
using admin_cms.Models.Infraestrutura.Autenticacao;
using smk_travel.Models;

namespace smk_travel.Controllers;

[Logado]
public class CentroDeCustosController : Controller
{
    private readonly DbContexto _context;

    public CentroDeCustosController(DbContexto context)
    {
        _context = context;
    }

    // GET: CentroDeCustos
    public async Task<IActionResult> Index()
    {
        return View(await _context.CentroDeCustos.ToListAsync());
    }

    // GET: CentroDeCustos/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var centroDeCusto = await _context.CentroDeCustos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (centroDeCusto == null)
        {
            return NotFound();
        }

        return View(centroDeCusto);
    }

    // GET: CentroDeCustos/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CentroDeCustos/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Codigo,Nome")] CentroDeCusto centroDeCusto)
    {
        if (ModelState.IsValid)
        {
            _context.Add(centroDeCusto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(centroDeCusto);
    }

    // GET: CentroDeCustos/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var centroDeCusto = await _context.CentroDeCustos.FindAsync(id);
        if (centroDeCusto == null)
        {
            return NotFound();
        }
        return View(centroDeCusto);
    }

    // POST: CentroDeCustos/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Nome")] CentroDeCusto centroDeCusto)
    {
        if (id != centroDeCusto.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(centroDeCusto);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentroDeCustoExists(centroDeCusto.Id))
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
        return View(centroDeCusto);
    }

    // GET: CentroDeCustos/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var centroDeCusto = await _context.CentroDeCustos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (centroDeCusto == null)
        {
            return NotFound();
        }

        return View(centroDeCusto);
    }

    // POST: CentroDeCustos/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var centroDeCusto = await _context.CentroDeCustos.FindAsync(id);
        _context.CentroDeCustos.Remove(centroDeCusto);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CentroDeCustoExists(int id)
    {
        return _context.CentroDeCustos.Any(e => e.Id == id);
    }
}
