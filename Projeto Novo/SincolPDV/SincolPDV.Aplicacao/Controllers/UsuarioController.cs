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

        // GET: Usuario
        public ActionResult Index()
        {
            if (UsuarioRepositorio.UsuarioLogado == null)
                return Redirect("/Usuario/Login");

            var FuncaoUsuario = funcaoUsuarioRepositorio.ListarTodos().ToList();
            var PerfilAcesso = perfilAcessoRepositorio.ListarTodos().ToList();
            var Status = statusRepositorio.ListarTodos().ToList();

            FuncaoUsuario.Add(new FuncaoUsuario { FuncaoUsuarioID = 0, Descricao = "<-- Selecione -->" });
            PerfilAcesso.Add(new PerfilAcesso { PerfilAcessoID = 0, Descricao = "<-- Selecione -->" });
            Status.Add(new Status { StatusId = 0, Descricao = "<-- Selecione -->" });

            ViewBag.FuncaoUsuario = FuncaoUsuario.OrderBy(x => x.FuncaoUsuarioID);
            ViewBag.PerfilAcesso = PerfilAcesso.OrderBy(x => x.PerfilAcessoID);
            ViewBag.Status = Status.OrderBy(x => x.StatusId);

            return View();
        }

        public JsonResult PreencheGrid(pesquisaUsuario usu)
        {
            List<Usuario> usuario = usuarioRepositorio.ListarTodos().ToList();

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

        public ActionResult NovoUsuario()
        {
            var FuncaoUsuario = funcaoUsuarioRepositorio.ListarTodos().ToList();
            var PerfilAcesso = perfilAcessoRepositorio.ListarTodos().ToList();

            FuncaoUsuario.Add(new FuncaoUsuario { FuncaoUsuarioID = 0, Descricao = "<-- Selecione -->" });
            PerfilAcesso.Add(new PerfilAcesso { PerfilAcessoID = 0, Descricao = "<-- Selecione -->" });

            ViewBag.FuncaoUsuario = FuncaoUsuario.OrderBy(x => x.FuncaoUsuarioID);
            ViewBag.PerfilAcesso = PerfilAcesso.OrderBy(x => x.PerfilAcessoID);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.DataCadastro = DateTime.Now;

                usuarioRepositorio.Adicionar(usuario);
                usuarioRepositorio.SalvarTodos();

                return RedirectToAction("Index");
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

            var FuncaoUsuario = funcaoUsuarioRepositorio.ListarTodos().ToList();
            var PerfilAcesso = perfilAcessoRepositorio.ListarTodos().ToList();
            var Status = statusRepositorio.ListarTodos().ToList();

            FuncaoUsuario.Add(new FuncaoUsuario { FuncaoUsuarioID = 0, Descricao = "<-- Selecione -->" });
            PerfilAcesso.Add(new PerfilAcesso { PerfilAcessoID = 0, Descricao = "<-- Selecione -->" });
            Status.Add(new Status { StatusId = 0, Descricao = "<-- Selecione -->" });

            ViewBag.FuncaoUsuario = FuncaoUsuario.OrderBy(x => x.FuncaoUsuarioID);
            ViewBag.PerfilAcesso = PerfilAcesso.OrderBy(x => x.PerfilAcessoID);
            ViewBag.Status = Status.OrderBy(x => x.StatusId);

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
