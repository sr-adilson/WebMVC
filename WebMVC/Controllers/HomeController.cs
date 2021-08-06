using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using WebMVC.Repository;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        Repositorio repository = new Repositorio();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabela()
        {
            List<Whisky> whiskies = repository.Read();
            return View(whiskies);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Salvar(Whisky model)
        {
            repository.Create(model);
            return View();
        }
        public ActionResult Deletar(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Tabela");
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            Whisky model = repository.Read(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(Whisky model)
        {
            repository.Update(model);
            return RedirectToAction("Tabela");
        }
    }
}