using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SysGames.Dal;
using SysGames.Models;

namespace SysGames.Controllers
{
    public class VideogameController : Controller
    {
        private SysGamesContext db = new SysGamesContext();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Videogame videogame)
        {
            if (ModelState.IsValid)
            {
                db.Videogames.Add(videogame);
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(videogame);
        }

        public ActionResult Edit(Videogame videogame)
        {
            return View(videogame);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditVG(Videogame videogame)
        {
            if (ModelState.IsValid)
            {
                var videogameUpdate = db.Videogames.First(c => c.ProdutoID == videogame.ProdutoID);
                videogameUpdate.Nome = videogame.Nome;
                videogameUpdate.Descricao = videogame.Descricao;
                videogameUpdate.Valor = videogame.Valor;
                videogameUpdate.QtdEstoque = videogame.QtdEstoque;
                videogameUpdate.Marca = videogame.Marca;
                videogameUpdate.Modelo = videogame.Modelo;
                db.SaveChanges();
                return RedirectToAction("Index", "Produto");
            }
            return View(videogame);
        }

        public ActionResult Details(Videogame videogame)
        {
            return View(videogame);
        }
    }
}