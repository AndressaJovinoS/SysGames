using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SysGames.Dal;
using SysGames.Models;

namespace SysGames.Controllers
{
    public class JogoController : Controller
    {
        private SysGamesContext db = new SysGamesContext();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                db.Jogos.Add(jogo);
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(jogo);
        }

        public ActionResult Edit(Jogo jogo)
        {
            return View(jogo);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditJG(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                var jogoUpdate = db.Jogos.First(c => c.ProdutoID == jogo.ProdutoID);
                jogoUpdate.Nome = jogo.Nome;
                jogoUpdate.Descricao = jogo.Descricao;
                jogoUpdate.Valor = jogo.Valor;
                jogoUpdate.QtdEstoque = jogo.QtdEstoque;
                jogoUpdate.Genero = jogo.Genero;
                jogoUpdate.Classificacao = jogo.Classificacao;
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(jogo);
        }

        public ActionResult Details(Jogo jogo)
        {
            return View(jogo);
        }
    }
}