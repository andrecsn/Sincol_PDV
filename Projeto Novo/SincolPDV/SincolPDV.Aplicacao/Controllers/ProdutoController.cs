using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SincolPDV.Dominio;
using SincolPDV.Repositorio.Implementacao;

namespace SincolPDV.Aplicacao.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        private FornecedorRepositorio fornecedorRepositorio = new FornecedorRepositorio();
        private FabricanteRepositorio fabricanteRepositorio = new FabricanteRepositorio();
        private MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        private EstoqueRepositorio estoqueRepositorio = new EstoqueRepositorio();
        private EntradaProdutoRepositorio entradaProdutoRepositorio = new EntradaProdutoRepositorio();
        private StatusRepositorio statusRepositorio = new StatusRepositorio();

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
                return Redirect("/NovoPdv/Usuario/Login");

            CarregaCombo();

            return View();
        }

        public JsonResult PreencheGrid(pesquisaProduto prod)
        {
            List<Produto> produto = produtoRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();

            if (prod.Nome != null)
                produto = produto.Where(x => x.Nome.Contains(prod.Nome)).ToList();

            if (prod.FornecedorID != 0)
                produto = produto.Where(x => x.FornecedorID == prod.FornecedorID).ToList();

            if (prod.FabricanteID != 0)
                produto = produto.Where(x => x.FabricanteID == prod.FabricanteID).ToList();

            if (prod.MarcaID != 0)
                produto = produto.Where(x => x.MarcaID == prod.MarcaID).ToList();

            return Json(new { data = produto }, JsonRequestBehavior.AllowGet);
        }

        private void CarregaCombo()
        {
            var Fornecedor = fornecedorRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();
            var Fabricante = fabricanteRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();
            var Marca = marcaRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();
            var Estoque = estoqueRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();

            Fornecedor.Add(new Fornecedor { FornecedorID = 0, Nome = "<-- Selecione -->" });
            Fabricante.Add(new Fabricante { FabricanteID = 0, Descricao = "<-- Selecione -->" });
            Marca.Add(new Marca { MarcaID = 0, Descricao = "<-- Selecione -->" });
            Estoque.Add(new Estoque { EstoqueID = 0, Descricao = "Selecione" });

            ViewBag.Fornecedor = Fornecedor.OrderBy(x => x.FornecedorID);
            ViewBag.Fabricante = Fabricante.OrderBy(x => x.FabricanteID);
            ViewBag.Marca = Marca.OrderBy(x => x.MarcaID);
            ViewBag.Estoque = Estoque.OrderBy(x => x.EstoqueID);
        }

        public ActionResult NovoProduto()
        {
            CarregaCombo();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                produto.DataCadastro = DateTime.Now;
                produto.UsuarioPaiID = usuarioPai;

                produtoRepositorio.Adicionar(produto);
                produtoRepositorio.SalvarTodos();

                return RedirectToAction("Index");
            }

            return View(produto);
        }

        [HttpGet]
        public ActionResult DetalhesProduto(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = produtoRepositorio.Listar(x => x.ProdutoID == id).FirstOrDefault();
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        public ActionResult EditarProduto(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = produtoRepositorio.Listar(x => x.ProdutoID == id).FirstOrDefault();
            if (produto == null)
            {
                return HttpNotFound();
            }

            CarregaCombo();

            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void EditarProduto(Produto prod)
        {
            Produto produto = produtoRepositorio.Listar(x => x.ProdutoID == prod.ProdutoID).FirstOrDefault();
            try
            {
                if (ModelState.IsValid)
                {
                    produto.Referencia = prod.Referencia;
                    produto.Nome = prod.Nome;
                    produto.Descricao = prod.Descricao;
                    produto.Modelo = produto.Modelo;
                    produto.FabricanteID = prod.FabricanteID;
                    produto.FornecedorID = prod.FornecedorID;
                    produto.MarcaID = prod.MarcaID;
                    produto.Imagem = prod.Imagem;
                    produto.precoUnitario = prod.precoUnitario;
                    produto.ValorTabela = prod.ValorTabela;
                    produto.EstoqueMinimo = prod.EstoqueMinimo;
                    produto.EstoqueMaximo = prod.EstoqueMaximo;
                    produto.Observacao = prod.Observacao;
                    produto.EstoqueID = prod.EstoqueID;
                    produto.Peso = prod.Peso;
                    produto.StatusId = prod.StatusBool ? 1 : 2;

                    produtoRepositorio.Atualizar(produto);
                    produtoRepositorio.SalvarTodos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult DeletarProduto(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = produtoRepositorio.Listar(x => x.ProdutoID == id).FirstOrDefault();
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        [HttpPost, ActionName("DeletarProduto")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed(Produto prod)
        {
            try
            {
                Produto produto = produtoRepositorio.Listar(x => x.ProdutoID == prod.ProdutoID).FirstOrDefault();

                produtoRepositorio.Excluir(x => x == produto);
                produtoRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }



        //================================ CÓDIGO DE BARRAS ==============================//
        //===============================================================================//

        #region Ações de Fabricante

        public JsonResult PreencheGridCodigoBarras(int id)
        {
            List<EntradaProdutos> entradaProduto = entradaProdutoRepositorio.ListarTodos().Where(x => x.Produto.ProdutoID == id).ToList();

            return Json(new { data = entradaProduto }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult NovoCodigoDeBarras(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntradaProdutos entradaProdutos = new EntradaProdutos();
            var codigoBarra = entradaProdutoRepositorio.Listar(x => x.ProdutoID == id).FirstOrDefault();

            if(codigoBarra == null)
                entradaProdutos.Produto = produtoRepositorio.Listar(x => x.ProdutoID == id).FirstOrDefault();

            if (entradaProdutos == null)
            {
                return HttpNotFound();
            }
            return View(entradaProdutos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoCodigoDeBarras(EntradaProdutos entradaProduto)
        {
            if (entradaProduto.CodigoBarras != 0)
            {
                entradaProduto.UsuarioID = UsuarioRepositorio.UsuarioLogado.UsuarioID;
                entradaProduto.DtEntrada = DateTime.Now;

                entradaProdutoRepositorio.Adicionar(entradaProduto);
                entradaProdutoRepositorio.SalvarTodos();

                //return RedirectToAction("NovoCodigoDeBarras");
            }

            return View(entradaProduto);
        }

        #endregion

        //================================== FABRICANTE =================================//
        //===============================================================================//
        #region Ações de Fabricante

        public JsonResult PreencheGridFabricante()
        {
            List<Fabricante> fabricante = fabricanteRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai & x.StatusId == 1).ToList();

            return Json(new { data = fabricante }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult NovoFabricante()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoFabricante(Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                fabricante.StatusId = statusRepositorio.Buscar(1).StatusId;
                fabricante.UsuarioPaiID = usuarioPai;

                fabricanteRepositorio.Adicionar(fabricante);
                fabricanteRepositorio.SalvarTodos();

                return RedirectToAction("NovoFabricante");
            }

            return View(fabricante);
        }

        public ActionResult DeletarFabricante(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = fabricanteRepositorio.Listar(x => x.FabricanteID == id).FirstOrDefault();
            if (fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        [HttpPost, ActionName("DeletarFabricante")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed2(Fabricante fab)
        {
            try
            {
                Fabricante fabricante = fabricanteRepositorio.Listar(x => x.FabricanteID == fab.FabricanteID).FirstOrDefault();

                fabricante.StatusId = statusRepositorio.Buscar(1).StatusId;

                fabricanteRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        //===================================== MARCA ====================================//
        //===============================================================================//
        #region Ações de Marca

        public JsonResult PreencheGridMarca()
        {
            List<Marca> marca = marcaRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai & x.StatusId == 1).ToList();

            return Json(new { data = marca }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult NovaMarca()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovaMarca(Marca marca)
        {
            if (ModelState.IsValid)
            {
                marca.StatusId = statusRepositorio.Buscar(1).StatusId;
                marca.UsuarioPaiID = usuarioPai;

                marcaRepositorio.Adicionar(marca);
                marcaRepositorio.SalvarTodos();

                return RedirectToAction("NovaMarca");
            }

            return View(marca);
        }

        public ActionResult DeletarMarca(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marca marca = marcaRepositorio.Listar(x => x.MarcaID == id).FirstOrDefault();
            if (marca == null)
            {
                return HttpNotFound();
            }
            return View(marca);
        }

        [HttpPost, ActionName("DeletarMarca")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed3(Marca mar)
        {
            try
            {
                Marca marca = marcaRepositorio.Listar(x => x.MarcaID == mar.MarcaID).FirstOrDefault();

                marca.StatusId = statusRepositorio.Buscar(2).StatusId;

                marcaRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        //==================================== ESTOQUE ===================================//
        //===============================================================================//
        #region Ações de Estoque

        public JsonResult PreencheGridEstoque()
        {
            List<Estoque> estoque = estoqueRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai & x.StatusId == 1).ToList();

            return Json(new { data = estoque }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult NovoEstoque()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoEstoque(Estoque estoque)
        {
            if (ModelState.IsValid)
            {
                estoque.StatusId = statusRepositorio.Buscar(1).StatusId;
                estoque.UsuarioPaiID = usuarioPai;

                estoqueRepositorio.Adicionar(estoque);
                estoqueRepositorio.SalvarTodos();

                return RedirectToAction("NovoEstoque");
            }

            return View(estoque);
        }

        public ActionResult DeletarEstoque(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estoque estoque = estoqueRepositorio.Listar(x => x.EstoqueID == id).FirstOrDefault();
            if (estoque == null)
            {
                return HttpNotFound();
            }
            return View(estoque);
        }

        [HttpPost, ActionName("DeletarEstoque")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed4(Estoque est)
        {
            try
            {
                Estoque estoque = estoqueRepositorio.Listar(x => x.EstoqueID == est.EstoqueID).FirstOrDefault();

                estoque.StatusId = statusRepositorio.Buscar(2).StatusId;

                estoqueRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


    }
}