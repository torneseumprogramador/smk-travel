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
    public class ViagensController : Controller
    {
        private readonly DbContexto _context;

        public ViagensController(DbContexto context)
        {
            _context = context;
        }

        // GET: Viagens
        public async Task<IActionResult> Index()
        {
            var dbContexto = _context.Viagens.Include(v => v.Alojamento).Include(v => v.Classe).Include(v => v.CompanhiaAerea).Include(v => v.EstadoDaViagem).Include(v => v.Funcionario).Include(v => v.Itinerario).Include(v => v.Motivo).Include(v => v.TipoDeBilhete);
            return View(await dbContexto.ToListAsync());
        }

        // GET: Viagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viagem = await _context.Viagens
                .Include(v => v.Alojamento)
                .Include(v => v.Classe)
                .Include(v => v.CompanhiaAerea)
                .Include(v => v.EstadoDaViagem)
                .Include(v => v.Funcionario)
                .Include(v => v.Itinerario)
                .Include(v => v.Motivo)
                .Include(v => v.TipoDeBilhete)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viagem == null)
            {
                return NotFound();
            }

            return View(viagem);
        }

        // GET: Viagens/Create
        public IActionResult Create()
        {
            ViewData["AlojamentoId"] = new SelectList(_context.Alojamentos, "Id", "Codigo");
            ViewData["Classeid"] = new SelectList(_context.Classes, "Id", "Codigo");
            ViewData["CompanhiaAereaId"] = new SelectList(_context.CompanhiaAereas, "Id", "Codigo");
            ViewData["EstadoDaViagemId"] = new SelectList(_context.EstadoDaViagens, "Id", "Codigo");
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo");
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo");
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Codigo");
            ViewData["TipoDeBilheteId"] = new SelectList(_context.TipoDeBilhetes, "Id", "Codigo");
            return View();
        }

        // POST: Viagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FuncionarioId,ItinerarioId,CompanhiaAereaId,DataSaida,DataChagada,AlojamentoId,TesteCovid,Comentarios,Hospede,DiasDeTrabalho,DataCriacao,DataAtualizacao,Documento,MotivoId,Classeid,TipoDeBilheteId,EstadoDaViagemId,Valor,Taxa,Taxa1")] Viagem viagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlojamentoId"] = new SelectList(_context.Alojamentos, "Id", "Codigo", viagem.AlojamentoId);
            ViewData["Classeid"] = new SelectList(_context.Classes, "Id", "Codigo", viagem.Classeid);
            ViewData["CompanhiaAereaId"] = new SelectList(_context.CompanhiaAereas, "Id", "Codigo", viagem.CompanhiaAereaId);
            ViewData["EstadoDaViagemId"] = new SelectList(_context.EstadoDaViagens, "Id", "Codigo", viagem.EstadoDaViagemId);
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo", viagem.FuncionarioId);
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo", viagem.ItinerarioId);
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Codigo", viagem.MotivoId);
            ViewData["TipoDeBilheteId"] = new SelectList(_context.TipoDeBilhetes, "Id", "Codigo", viagem.TipoDeBilheteId);
            return View(viagem);
        }

        // GET: Viagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viagem = await _context.Viagens.FindAsync(id);
            if (viagem == null)
            {
                return NotFound();
            }
            ViewData["AlojamentoId"] = new SelectList(_context.Alojamentos, "Id", "Codigo", viagem.AlojamentoId);
            ViewData["Classeid"] = new SelectList(_context.Classes, "Id", "Codigo", viagem.Classeid);
            ViewData["CompanhiaAereaId"] = new SelectList(_context.CompanhiaAereas, "Id", "Codigo", viagem.CompanhiaAereaId);
            ViewData["EstadoDaViagemId"] = new SelectList(_context.EstadoDaViagens, "Id", "Codigo", viagem.EstadoDaViagemId);
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo", viagem.FuncionarioId);
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo", viagem.ItinerarioId);
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Codigo", viagem.MotivoId);
            ViewData["TipoDeBilheteId"] = new SelectList(_context.TipoDeBilhetes, "Id", "Codigo", viagem.TipoDeBilheteId);
            return View(viagem);
        }

        // POST: Viagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FuncionarioId,ItinerarioId,CompanhiaAereaId,DataSaida,DataChagada,AlojamentoId,TesteCovid,Comentarios,Hospede,DiasDeTrabalho,DataCriacao,DataAtualizacao,Documento,MotivoId,Classeid,TipoDeBilheteId,EstadoDaViagemId,Valor,Taxa,Taxa1")] Viagem viagem)
        {
            if (id != viagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViagemExists(viagem.Id))
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
            ViewData["AlojamentoId"] = new SelectList(_context.Alojamentos, "Id", "Codigo", viagem.AlojamentoId);
            ViewData["Classeid"] = new SelectList(_context.Classes, "Id", "Codigo", viagem.Classeid);
            ViewData["CompanhiaAereaId"] = new SelectList(_context.CompanhiaAereas, "Id", "Codigo", viagem.CompanhiaAereaId);
            ViewData["EstadoDaViagemId"] = new SelectList(_context.EstadoDaViagens, "Id", "Codigo", viagem.EstadoDaViagemId);
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo", viagem.FuncionarioId);
            ViewData["ItinerarioId"] = new SelectList(_context.Itinerarios, "Id", "Codigo", viagem.ItinerarioId);
            ViewData["MotivoId"] = new SelectList(_context.Motivos, "Id", "Codigo", viagem.MotivoId);
            ViewData["TipoDeBilheteId"] = new SelectList(_context.TipoDeBilhetes, "Id", "Codigo", viagem.TipoDeBilheteId);
            return View(viagem);
        }

        // GET: Viagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viagem = await _context.Viagens
                .Include(v => v.Alojamento)
                .Include(v => v.Classe)
                .Include(v => v.CompanhiaAerea)
                .Include(v => v.EstadoDaViagem)
                .Include(v => v.Funcionario)
                .Include(v => v.Itinerario)
                .Include(v => v.Motivo)
                .Include(v => v.TipoDeBilhete)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viagem == null)
            {
                return NotFound();
            }

            return View(viagem);
        }

        // POST: Viagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viagem = await _context.Viagens.FindAsync(id);
            _context.Viagens.Remove(viagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViagemExists(int id)
        {
            return _context.Viagens.Any(e => e.Id == id);
        }
    }
}
