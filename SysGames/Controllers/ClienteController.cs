using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SysGames.Dal;
using SysGames.Models;

namespace SysGames.Controllers
{
    public class ClienteController : Controller
    {
        private SysGamesContext db = new SysGamesContext();
        // GET: Cliente
        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Edit(int id)
        {
            return View(db.Clientes.First(c => c.ClienteID == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteUpdate = db.Clientes.First(c => c.ClienteID == cliente.ClienteID);
                clienteUpdate.CPF = cliente.CPF;
                clienteUpdate.Nome = cliente.Nome;
                clienteUpdate.Email = cliente.Email;
                clienteUpdate.Telefone = cliente.Telefone;
                clienteUpdate.Senha = cliente.Senha;
                clienteUpdate.Logradouro = cliente.Logradouro;
                clienteUpdate.Localidade = cliente.Localidade;
                clienteUpdate.UF = cliente.UF;
                clienteUpdate.Bairro = cliente.Bairro;
                clienteUpdate.CEP = cliente.CEP;
                clienteUpdate.Complemento = cliente.Complemento;
                clienteUpdate.Numero = cliente.Numero;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Details(int id)
        {
            return View(db.Clientes.First(c => c.ClienteID == id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.Clientes.First(c => c.ClienteID == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            db.Clientes.Remove(db.Clientes.First(c => c.ClienteID == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}