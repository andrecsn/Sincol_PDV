using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;

namespace SincolPDV.BLL
{
    public class Usuario
    {
        UsuarioDAL Usu = new UsuarioDAL();

        #region atributos

        public string Tabela;
        public string ColunaCod;
        public string ColunaNome;
        public string ColunaLogin;
        public string ColunaSenha;
        public string ColunaPerfil;
        public string ColunaAtivo;
        
        public int codigo;
        string login;
        public string nome;
        string senha;
        int status;
        int perfil_acesso;

        #endregion


        #region Propriedades

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Perfil_Acesso
        {
            get { return perfil_acesso; }
            set { perfil_acesso = value; }
        }

        #endregion


        #region Metodos


        UsuarioDAL usu = new UsuarioDAL();
        Acesso exe = new Acesso();
        int result;


        public int CadastrarUsuario()
        {
            return result = usu.InserirUsuario("P_CADASTRAR_USUARIO", Nome, Login, Senha, Status, Perfil_Acesso);
        }

        public int AlterarUsuario()
        {
            return result = usu.AlterarUsuario("P_ALTERAR_USUARIO", Codigo, Nome, Login, Senha, Status, Perfil_Acesso);
        }

        public int ExcluirUsuario()
        {
            return result = usu.ExcluirUsuario("P_DELETAR_USUARIO", Codigo);
        }

        public int Consulta()
        {

            DataTable dt = Usu.ConsultaUsuario("P_CONSULTAR_LISTA_USUARIO_POR_CODIGO", Codigo);

            if (dt.Rows.Count > 0)
            {

                Codigo = Convert.ToInt32(dt.Rows[0]["USU_CODIGO"].ToString());
                Nome = dt.Rows[0]["USU_NOME"].ToString();
                Login= dt.Rows[0]["USU_LOGIN"].ToString();
                Senha = dt.Rows[0]["USU_SENHA"].ToString();

                Perfil_Acesso = Convert.ToInt32(dt.Rows[0]["PERFIL_ACESSO"].ToString());

                Status = 0;
                if (dt.Rows[0]["USU_STATUS"].ToString() != "")
                {
                    Status = Convert.ToInt32(dt.Rows[0]["USU_STATUS"].ToString());
                }

                return 1;
            }
            return 0;
        }


        public DataTable Lista()
        {
            try
            {
                return Usu.Listar(Tabela, ColunaCod, ColunaNome, Nome, ColunaLogin, ColunaSenha, ColunaPerfil, ColunaAtivo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
