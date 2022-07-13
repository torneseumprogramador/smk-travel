using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            carregaFuncionarioViewBag(funcionarioId);
            var dbContexto = _context.ArquivoDeFuncionarios.Include(a => a.Funcionario);
            return View(await dbContexto.ToListAsync());
        }

        private void carregaFuncionarioViewBag(int funcionarioId)
        {
            ViewData["Funcionario"] = _context.Funcionarios.Find(funcionarioId);
        }

        // GET: ArquivoDeFuncionarios/Create
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Create")]
        public IActionResult Create([FromRoute] int funcionarioId)
        {
            carregaFuncionarioViewBag(funcionarioId);
            
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo");
            return View();
        }

        // POST: ArquivoDeFuncionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Create")]
        public async Task<IActionResult> Create([FromRoute] int funcionarioId, IFormFile Arquivo, [Bind("Id,FuncionarioId")] ArquivoDeFuncionario arquivoDeFuncionario)
        {
            carregaFuncionarioViewBag(funcionarioId);

            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("/bin/Debug/net6.0/", "");

            string uploads = Path.Combine($"{path}/wwwroot/", "uploads");
            if (Arquivo.Length > 0) 
            {
                string filePath = Path.Combine(uploads, Arquivo.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create)) 
                {
                    await Arquivo.CopyToAsync(fileStream);
                }
            }

            var arquivo = $"/uploads/{Arquivo.FileName}";
            
            arquivoDeFuncionario.FuncionarioId = funcionarioId;
            arquivoDeFuncionario.Arquivo = arquivo;

            if (!string.IsNullOrEmpty(arquivoDeFuncionario.Arquivo))
            {
                _context.Add(arquivoDeFuncionario);
                await _context.SaveChangesAsync();
                return Redirect($"/funcionarios/{funcionarioId}/ArquivoDeFuncionarios");
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "Id", "Codigo", arquivoDeFuncionario.FuncionarioId);
            return View(arquivoDeFuncionario);
        }

        // GET: ArquivoDeFuncionarios/Delete/5
        [Route("/Funcionarios/{funcionarioId}/ArquivoDeFuncionarios/Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int funcionarioId, int? id)
        {
            carregaFuncionarioViewBag(funcionarioId);
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
