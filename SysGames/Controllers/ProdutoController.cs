using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SysGames.Dal;
using SysGames.Models;

namespace SysGames.Controllers
{
    public class ProdutoController : Controller
    {
        private SysGamesContext db = new SysGamesContext();
        // GET: Cliente
        public ActionResult Index()
        {
            var list = db.Produtos.OrderBy(l => l.Tipo).ToList();
            return View(list);
        }

        public ActionResult Edit(int id)
        {
            var prod = db.Produtos.First(c => c.ProdutoID == id);
            if (ReferenceEquals(prod.GetType(), new Videogame().GetType()))
            {
                return RedirectToAction("Edit", "Videogame", prod);
            }
            else if (ReferenceEquals(prod.GetType(), new Acessorio().GetType()))
            {
                return RedirectToAction("Edit", "Acessorio", prod);
            }
            else if (ReferenceEquals(prod.GetType(), new Jogo().GetType()))
            {
                return RedirectToAction("Edit", "Jogo", prod);
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var prod = db.Produtos.First(c => c.ProdutoID == id);
            if (ReferenceEquals(prod.GetType(), new Videogame().GetType()))
            {
                return RedirectToAction("Details", "Videogame", prod);
            }
            else if (ReferenceEquals(prod.GetType(), new Acessorio().GetType()))
            {
                return RedirectToAction("Details", "Acessorio", prod);
            }
            else if (ReferenceEquals(prod.GetType(), new Jogo().GetType()))
            {
                return RedirectToAction("Details", "Jogo", prod);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View(db.Produtos.First(c => c.ProdutoID == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            db.Produtos.Remove(db.Produtos.First(c => c.ProdutoID == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}