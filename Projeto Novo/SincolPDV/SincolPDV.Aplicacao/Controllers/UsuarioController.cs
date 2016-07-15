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
    public class UsuarioController : Controller
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private FuncaoUsuarioRepositorio funcaoUsuarioRepositorio = new FuncaoUsuarioRepositorio();
        private PerfilAcessoRepositorio perfilAcessoRepositorio = new PerfilAcessoRepositorio();
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
                return Redirect("/Usuario/Login");

            CarregaCombo();

            return View();
        }

        public JsonResult PreencheGrid(pesquisaUsuario usu)
        {
            List<Usuario> usuario = usuarioRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai & x.UsuarioID != UsuarioRepositorio.UsuarioLogado.UsuarioID).ToList();

            if (usu.Nome != null)
                usuario = usuario.Where(x => x.Nome.Contains(usu.Nome)).ToList();

            if (usu.FuncaoUsuarioID != 0)
                usuario = usuario.Where(x => x.FuncaoUsuarioID == usu.FuncaoUsuarioID).ToList();

            if (usu.PerfilAcessoID != 0)
                usuario = usuario.Where(x => x.PerfilAcessoID == usu.PerfilAcessoID).ToList();

            if (usu.StatusId != 0)
                usuario = usuario.Where(x => x.Status.StatusId == usu.StatusId).ToList();

            return Json(new { data = usuario }, JsonRequestBehavior.AllowGet);
        }

        private void CarregaCombo()
        {
            var FuncaoUsuario = funcaoUsuarioRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();
            var PerfilAcesso = perfilAcessoRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai).ToList();
            var Status = statusRepositorio.ListarTodos().ToList();

            FuncaoUsuario.Add(new FuncaoUsuario { FuncaoUsuarioID = 0, Descricao = "<-- Selecione -->" });
            PerfilAcesso.Add(new PerfilAcesso { PerfilAcessoID = 0, Descricao = "<-- Selecione -->" });
            Status.Add(new Status { StatusId = 0, Descricao = "<-- Selecione -->" });

            ViewBag.FuncaoUsuario = FuncaoUsuario.OrderBy(x => x.FuncaoUsuarioID);
            ViewBag.PerfilAcesso = PerfilAcesso.OrderBy(x => x.PerfilAcessoID);
            ViewBag.Status = Status.OrderBy(x => x.StatusId);
        }

        public ActionResult NovoUsuario()
        {
            CarregaCombo();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.DataCadastro = DateTime.Now;
                usuario.UsuarioPaiID = usuarioPai;

                usuarioRepositorio.Adicionar(usuario);
                usuarioRepositorio.SalvarTodos();

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        [HttpGet]
        public ActionResult DetalhesUsuario(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = usuarioRepositorio.Listar(x => x.UsuarioID == id).FirstOrDefault();
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        public ActionResult EditarUsuario(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = usuarioRepositorio.Listar(x => x.UsuarioID == id).FirstOrDefault();
            if (usuario == null)
            {
                return HttpNotFound();
            }

            CarregaCombo();

            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void EditarUsuario(Usuario usu)
        {
            Usuario usuario = usuarioRepositorio.Listar(x => x.UsuarioID == usu.UsuarioID).FirstOrDefault();
            try
            {
                if (ModelState.IsValid)
                {
                    usuario.Nome = usu.Nome;
                    usuario.Email = usu.Email;
                    usuario.Telefone = usu.Telefone;
                    usuario.FuncaoUsuarioID = usu.FuncaoUsuarioID;
                    usuario.PerfilAcessoID = usu.PerfilAcessoID;
                    usuario.Login = usu.Login;
                    usuario.Senha = usu.Senha;
                    usuario.StatusId = usu.StatusBool ? 1 : 2;

                    usuarioRepositorio.Atualizar(usuario);
                    usuarioRepositorio.SalvarTodos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult DeletarUsuario(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = usuarioRepositorio.Listar(x => x.UsuarioID == id).FirstOrDefault();
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost, ActionName("DeletarUsuario")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed(Usuario usu)
        {
            try
            {
                Usuario usuario = usuarioRepositorio.Listar(x => x.UsuarioID == usu.UsuarioID).FirstOrDefault();

                usuarioRepositorio.Excluir(x => x == usuario);
                usuarioRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }


        //==================================== LOGIN ====================================//
        //===============================================================================//

        #region Ações de Login

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logar(Usuario usuario)
        {
            var response = false;

            if (usuarioRepositorio.AutenticarUsuario(usuario.Login, usuario.Senha))
            {
                //caso esteja correto redirecionamos para a página
                response = true;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                response = false;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Deslogar()
        {
            usuarioRepositorio.Deslogar();

            return Redirect("/Usuario/Login");
        }

        #endregion

        //==================================== FUNÇÃO ====================================//
        //===============================================================================//
        #region Ações de Função

        public JsonResult PreencheGridFuncao()
        {
            List<FuncaoUsuario> funcao = funcaoUsuarioRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai & x.StatusId == 1).ToList();

            return Json(new { data = funcao }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult NovaFuncao()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovaFuncao(FuncaoUsuario funcao)
        {
            if (ModelState.IsValid)
            {
                funcao.StatusId = statusRepositorio.Buscar(1).StatusId;
                funcao.UsuarioPaiID = usuarioPai;

                funcaoUsuarioRepositorio.Adicionar(funcao);
                funcaoUsuarioRepositorio.SalvarTodos();

                return RedirectToAction("NovoUsuario");
            }

            return View(funcao);
        }

        public ActionResult DeletarFuncao(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuncaoUsuario funcao = funcaoUsuarioRepositorio.Listar(x => x.FuncaoUsuarioID == id).FirstOrDefault();
            if (funcao == null)
            {
                return HttpNotFound();
            }
            return View(funcao);
        }

        [HttpPost, ActionName("DeletarFuncao")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed2(FuncaoUsuario func)
        {
            try
            {
                FuncaoUsuario funcao = funcaoUsuarioRepositorio.Listar(x => x.FuncaoUsuarioID == func.FuncaoUsuarioID).FirstOrDefault();

                funcao.StatusId = statusRepositorio.Buscar(2).StatusId;

                funcaoUsuarioRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        //=============================== PERFIL DE ACESSO ===============================//
        //===============================================================================//

        #region Ações de Perfil de Acesso

        public JsonResult PreencheGridPerfilAcesso()
        {
            List<PerfilAcesso> perfilAcesso = perfilAcessoRepositorio.ListarTodos().Where(x => x.UsuarioPaiID == usuarioPai & x.StatusId == 1).ToList();

            return Json(new { data = perfilAcesso }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult NovoPerfilAcesso()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoPerfilAcesso(PerfilAcesso perfilAcesso)
        {
            if (ModelState.IsValid)
            {
                perfilAcesso.StatusId = statusRepositorio.Buscar(1).StatusId;
                perfilAcesso.UsuarioPaiID = usuarioPai;

                perfilAcessoRepositorio.Adicionar(perfilAcesso);
                perfilAcessoRepositorio.SalvarTodos();

                return RedirectToAction("NovoUsuario");
            }

            return View(perfilAcesso);
        }

        public ActionResult DeletarPerfilAcesso(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilAcesso perfilAcesso = perfilAcessoRepositorio.Listar(x => x.PerfilAcessoID == id).FirstOrDefault();
            if (perfilAcesso == null)
            {
                return HttpNotFound();
            }
            return View(perfilAcesso);
        }

        [HttpPost, ActionName("DeletarPerfilAcesso")]
        [ValidateAntiForgeryToken]
        public void DeleteConfirmed3(PerfilAcesso pAcesso)
        {
            try
            {
                PerfilAcesso perfilAcesso = perfilAcessoRepositorio.Listar(x => x.PerfilAcessoID == pAcesso.PerfilAcessoID).FirstOrDefault();

                perfilAcesso.StatusId = statusRepositorio.Buscar(2).StatusId;
                perfilAcessoRepositorio.SalvarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

    }
}
