using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SincolPDV.Dominio;
using SincolPDV.Repositorio.Compartilhado;
using SincolPDV.Repositorio.Implementacao;

namespace SincolPDV.Aplicacao.Controllers
{
    public class ClienteController : Controller
    {
        private Contexto db = new Contexto();
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(clienteRepositorio.ListarTodos());
        }

        [HttpGet]
        public ActionResult DetalhesCliente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = clienteRepositorio.Listar(x => x.ClienteID == id).FirstOrDefault();
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult NovoCliente()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.DtCadastro = DateTime.Now;
                cliente.DtAtualizacao = DateTime.Now;

                clienteRepositorio.Adicionar(cliente);
                clienteRepositorio.SalvarTodos();

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public ActionResult EditarCliente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = clienteRepositorio.Listar(x => x.ClienteID == id).FirstOrDefault();
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                clienteRepositorio.Atualizar(cliente);
                clienteRepositorio.SalvarTodos();

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public ActionResult DeletarCliente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = clienteRepositorio.Listar(x => x.ClienteID == id).FirstOrDefault();
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("DeletarCliente")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = clienteRepositorio.Listar(x => x.ClienteID == id).FirstOrDefault();

            clienteRepositorio.Excluir(x => x == cliente);
            clienteRepositorio.SalvarTodos();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
