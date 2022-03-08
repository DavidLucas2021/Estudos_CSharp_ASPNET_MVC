using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNET_MVC5.Models;

namespace ASPNET_MVC5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoasID = 1,
                Nome = "David",
                Tipo = "Funcionário"
            };
            return View(pessoa);
        }
        public ActionResult Contatos()
        {
            return View();
        }
        [HttpPost] //REQUISIÇÃO HTTP DE DADOS 
        public ActionResult List(int IDPESSOA, string NOMEPESSOA, string TIPO)
        {
            ViewData["PessoasID"] = IDPESSOA;
            ViewData["Nome"] = NOMEPESSOA;
            ViewData["Tipo"] = TIPO;
            return View();
        }
    }
}