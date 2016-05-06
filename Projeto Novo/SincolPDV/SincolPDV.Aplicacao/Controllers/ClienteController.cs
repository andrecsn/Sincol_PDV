using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Linq.Dynamic;
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
        private StatusRepositorio statusRepositorio = new StatusRepositorio();

        public ActionResult Index()
        {
            if (UsuarioRepositorio.UsuarioLogado == null)
                return Redirect("/Usuario/Login");

            ViewBag.Status = statusRepositorio.ListarTodos().ToList();

            return View();
        }

        public JsonResult PreencheGrid(pesquisa clie)
        {
            List<Cliente> cliente = clienteRepositorio.ListarTodos().ToList();

            if (clie.Nome != null)
                cliente = cliente.Where(x => x.Nome.Contains(clie.Nome)).ToList();

            if (clie.Sexo != null)
                cliente = cliente.Where(x => x.Sexo == clie.Sexo).ToList();

            if (clie.StatusId != 0)
                cliente = cliente.Where(x => x.Status.StatusId == clie.StatusId).ToList();

            return Json(new { data = cliente }, JsonRequestBehavior.AllowGet);
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

        public ActionResult NovoCliente()
        {
            return View();
        }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void EditarCliente(Cliente clie)
        {
            Cliente cliente = clienteRepositorio.Listar(x => x.ClienteID == clie.ClienteID).FirstOrDefault();
            try
            {
                if (ModelState.IsValid)
                {
                    cliente.Nome = clie.Nome;
                    cliente.Sexo = clie.Sexo;
                    cliente.Email = clie.Email;
                    cliente.tp_pessoa = clie.tp_pessoa;
                    cliente.CPF = clie.CPF;
                    cliente.CNPJ = clie.CNPJ;
                    cliente.Telefone = clie.Telefone;
                    cliente.Endereco = clie.Endereco;
                    cliente.DtNascimento = clie.DtNascimento;
                    cliente.LimiteCredito = clie.LimiteCredito;
                    cliente.LimiteDias = clie.LimiteDias;
                    cliente.DtAtualizacao = DateTime.Now;
                    cliente.StatusId = clie.StatusBool ? 1 : 2;

                    clienteRepositorio.Atualizar(cliente);
                    clienteRepositorio.SalvarTodos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

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

        [HttpPost, ActionName("DeletarCliente")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed(Cliente clie)
        {
            try
            {
                Cliente cliente = clienteRepositorio.Listar(x => x.ClienteID == clie.ClienteID).FirstOrDefault();

                clienteRepositorio.Excluir(x => x == cliente);
                clienteRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
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
