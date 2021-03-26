using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SysGames.Dal;
using SysGames.Models;

namespace SysGames.Controllers
{
    public class AcessorioController : Controller
    {
        // GET: Acessorio
        private SysGamesContext db = new SysGamesContext();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Acessorio acessorio)
        {
            if (ModelState.IsValid)
            {
                db.Acessorios.Add(acessorio);
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(acessorio);
        }

        public ActionResult Edit(Acessorio acessorio)
        {
            return View(acessorio);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditA(Acessorio acessorio)
        {
            if (ModelState.IsValid)
            {
                var acessorioUpdate = db.Acessorios.First(c => c.ProdutoID == acessorio.ProdutoID);
                acessorioUpdate.Nome = acessorio.Nome;
                acessorioUpdate.Descricao = acessorio.Descricao;
                acessorioUpdate.Valor = acessorio.Valor;
                acessorioUpdate.QtdEstoque = acessorio.QtdEstoque;
                acessorioUpdate.Tipo = acessorio.Tipo;
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(acessorio);
        }
        public ActionResult Details(Acessorio acessorio)
        {
            return View(acessorio);
        }
    }
}