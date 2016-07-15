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
    public class FornecedorController : Controller
    {
        private Contexto db = new Contexto();
        private FornecedorRepositorio fornecedorRepositorio = new FornecedorRepositorio();
        private StatusRepositorio statusRepositorio = new StatusRepositorio();
        private DadosBancariosRepositorio dadosBancariosRepositorio = new DadosBancariosRepositorio();

        private static int UsuarioPai()
        {
            Usuario usuario = UsuarioRepositorio.UsuarioLogado;

            if (usuario != null)
                return usuario.UsuarioPaiID == null ? usuario.UsuarioID : Convert.ToInt32(usuario.UsuarioPaiID);
            else
                return 0;
        }
        int usuarioPai = UsuarioPai();

        public ActionResult Index()
        {
            if (UsuarioRepositorio.UsuarioLogado == null)
                return Redirect("/Usuario/Login");

            CarregaCombo();

            return View();
        }

        private void CarregaCombo()
        {
            var DadosBancarios = dadosBancariosRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai & x.StatusId == 1).ToList();
            var Status = statusRepositorio.ListarTodos().ToList();

            DadosBancarios.Add(new DadosBancarios { DadosBancariosID = 0, Descricao = "<-- Selecione -->" });
            Status.Add(new Status { StatusId = 0, Descricao = "<-- Selecione -->" });

            ViewBag.DadosBancarios = DadosBancarios.OrderBy(x => x.DadosBancariosID);
            ViewBag.Status = Status.OrderBy(x => x.StatusId);
        }

        public JsonResult PreencheGrid(pesquisaFornecedor forn)
        {
            List<Fornecedor> fornecedor = fornecedorRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();

            if (forn.Nome != null)
                fornecedor = fornecedor.Where(x => x.Nome.Contains(forn.Nome)).ToList();

            if (forn.Pessoa != null)
                fornecedor = fornecedor.Where(x => x.Pessoa == forn.Pessoa).ToList();

            if (forn.StatusId != 0)
                fornecedor = fornecedor.Where(x => x.Status.StatusId == forn.StatusId).ToList();

            return Json(new { data = fornecedor }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult DetalhesFornecedor(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = fornecedorRepositorio.Listar(x => x.FornecedorID == id).FirstOrDefault();
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        public ActionResult NovoFornecedor()
        {
            CarregaCombo();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoFornecedor(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                fornecedor.DtCadastro = DateTime.Now;
                fornecedor.UsuarioPaiID = usuarioPai;

                fornecedorRepositorio.Adicionar(fornecedor);
                fornecedorRepositorio.SalvarTodos();

                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        public ActionResult EditarFornecedor(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = fornecedorRepositorio.Listar(x => x.FornecedorID == id).FirstOrDefault();
            if (fornecedor == null)
            {
                return HttpNotFound();
            }

            CarregaCombo();

            return View(fornecedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void EditarFornecedor(Fornecedor forn)
        {
            Fornecedor fornecedor = fornecedorRepositorio.Listar(x => x.FornecedorID == forn.FornecedorID).FirstOrDefault();
            try
            {
                if (ModelState.IsValid)
                {
                    fornecedor.Nome = forn.Nome;
                    fornecedor.Pessoa = forn.Pessoa;
                    fornecedor.Email = forn.Email;
                    fornecedor.CPF = forn.CPF;
                    fornecedor.CNPJ = forn.CNPJ;
                    fornecedor.Telefone = forn.Telefone;
                    fornecedor.Endereco = forn.Endereco;
                    fornecedor.Observacao = forn.Observacao;
                    fornecedor.StatusId = forn.StatusBool ? 1 : 2;

                    fornecedorRepositorio.Atualizar(fornecedor);
                    fornecedorRepositorio.SalvarTodos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult DeletarFornecedor(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fornecedor fornecedor = fornecedorRepositorio.Listar(x => x.FornecedorID == id).FirstOrDefault();
            if (fornecedor == null)
            {
                return HttpNotFound();
            }
            return View(fornecedor);
        }

        [HttpPost, ActionName("DeletarFornecedor")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed(Fornecedor forn)
        {
            try
            {
                Fornecedor fornecedor = fornecedorRepositorio.Listar(x => x.FornecedorID == forn.FornecedorID).FirstOrDefault();

                fornecedor.StatusId = fornecedorRepositorio.Buscar(2).StatusId;

                fornecedorRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}