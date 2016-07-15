using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web;
using SincolPDV.Repositorio.Implementacao.Base;
using SincolPDV.Repositorio.Compartilhado;
using SincolPDV.Dominio;

namespace SincolPDV.Repositorio.Implementacao
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {
        static Contexto contexto = new Contexto();

        public void Deslogar()
        {
            HttpCookie Usuario = new HttpCookie("CookieAutenticacao")
            {
                Expires = DateTime.Now.AddDays(-1),
                Value = null
            };

            HttpContext.Current.Response.SetCookie(Usuario);
        }


        //Propriedade que verifica se o usuário encontra-se logado.
        public static Usuario UsuarioLogado
        {
            get

            {
                var Usuario = HttpContext.Current.Request.Cookies["CookieAutenticacao"];

                if (Usuario == null)
                {
                    return null;
                }
                else
                {
                    string NovoToken = Seguranca.Descriptografar(Usuario.Value.ToString());

                    int IDUsuario;

                    if (int.TryParse(NovoToken, out IDUsuario))
                    {
                        return GetUsuarioByID(IDUsuario);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        //Recuperando o usuário pelo ID
        public static Usuario GetUsuarioByID(int CodigoUsuario)
        {
            var Consulta = (from usuario in contexto.Usuario
                            where usuario.UsuarioID == CodigoUsuario
                            select usuario).SingleOrDefault();

            return Consulta;
        }

        /// <summary>
        /// Com base no Username e no Password, este método autentica o usuário e o direciona para o local correto.
        /// </summary>
        /// <param name="_Username"></param>
        /// <param name="_Password"></param>
        /// <returns></returns>
        public bool AutenticarUsuario(string _Username, string _Password)
        {
            try
            {
                var consulta = (from u in contexto.Usuario
                                        where u.Login == _Username && u.Senha == _Password && u.StatusId == 1
                                        select u).SingleOrDefault();

                if (consulta == null)
                {
                    return false;
                }
                else
                {
                    //Criando um objeto cookie
                    HttpCookie UserCookie = new HttpCookie("CookieAutenticacao");

                    //Setando o ID do usuário no cookie
                    UserCookie.Value = Seguranca.Criptografar(consulta.UsuarioID.ToString());

                    //Definindo o prazo de vida do cookie
                    UserCookie.Expires = DateTime.Now.AddHours(12);

                    //Adicionando o cookie no contexto da aplicação
                    HttpContext.Current.Response.Cookies.Add(UserCookie);

                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
