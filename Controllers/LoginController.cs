using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using smk_travel.Servicos.Database;

namespace smk_travel.LoginController
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly DbContexto _context;

        public LoginController(DbContexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/login/logar")]
        [HttpPost]
        public IActionResult Logar(string email, string senha)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                ViewBag.erro = "Digite o e-mail e a senha";
            }
            else
            {
                var adms = _context.Administradores.Where(a => a.Email == email && a.Senha == senha).ToList();
                if(adms.Count > 0)
                {
                    this.HttpContext.Response.Cookies.Append("smk_travel", adms.First().Id.ToString(), new CookieOptions
                    {
                        Expires = DateTimeOffset.UtcNow.AddDays(1),
                        HttpOnly = true,
                    });

                    Response.Redirect("/");
                }
                else
                {
                    ViewBag.erro = "Usuário ou senha inválidos";
                }

            }
            return View("Index");
        }
    }
}