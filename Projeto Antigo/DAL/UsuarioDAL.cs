using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SincolPDV.DAL
{
    public class UsuarioDAL
    {

        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public UsuarioDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }

        public DataTable ConsultaUsuario(string procedure, int campo)
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.Int);
            pfiltro.Value = campo;
            oda.Fill(i);

            return i;
        }


        public DataTable Listar(string Tabela, string ColunaCod, string ColunaNome, string nome, string ColunaLogin, string ColunaSenha, string ColunaPerfil, string ColunaAtivo)
        {
            DataTable i = new DataTable();
            oda = new SqlDataAdapter("select " + ColunaCod + " as Codigo, " + ColunaNome + " as Nome, " + ColunaLogin + " as Login, " + ColunaSenha + " as Senha, pera.pera_descricao as Perfil, " + ColunaAtivo + " as Ativo from " + Tabela + " USU, perfil_acesso pera where usu.pera_codigo = pera.pera_codigo order by " + ColunaCod, _conn);
            oda.Fill(i);
            return i;
        }


        public int InserirUsuario(string procedure, string usu_nome, string usu_login, string usu_senha, int usu_status,
            int usu_perfil_acesso)
        {

            try
            {
                int result;
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pusu_nome = new SqlParameter("@nome", SqlDbType.Text);
                pusu_nome.Value = usu_nome;
                SqlParameter pusu_login = new SqlParameter("@login", SqlDbType.Text);
                pusu_login.Value = usu_login;
                SqlParameter pusu_senha = new SqlParameter("@senha", SqlDbType.Text);
                pusu_senha.Value = usu_senha;
                SqlParameter pusu_status = new SqlParameter("@status", SqlDbType.Int);
                pusu_status.Value = usu_status;
                SqlParameter pusu_perfil_acesso = new SqlParameter("@perfil_acesso", SqlDbType.Int);
                pusu_perfil_acesso.Value = usu_perfil_acesso;


                comando.Parameters.Add(pusu_nome);
                comando.Parameters.Add(pusu_login);
                comando.Parameters.Add(pusu_senha);
                comando.Parameters.Add(pusu_status);
                comando.Parameters.Add(pusu_perfil_acesso);
                return result = comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir Cliente:" + ex.Message);
            }

        }



        public int AlterarUsuario(string procedure, int usu_codigo, string usu_nome, string usu_login, string usu_senha, int usu_status,
            int usu_perfil_acesso)
        {

            try
            {

                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pusu_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                pusu_codigo.Value = usu_codigo;
                SqlParameter pusu_nome = new SqlParameter("@nome", SqlDbType.Text);
                pusu_nome.Value = usu_nome;
                SqlParameter pusu_login = new SqlParameter("@login", SqlDbType.Text);
                pusu_login.Value = usu_login;
                SqlParameter pusu_senha = new SqlParameter("@senha", SqlDbType.Text);
                pusu_senha.Value = usu_senha;
                SqlParameter pusu_status = new SqlParameter("@status", SqlDbType.Int);
                pusu_status.Value = usu_status;
                SqlParameter pusu_perfil_acesso = new SqlParameter("@perfil_acesso", SqlDbType.Int);
                pusu_perfil_acesso.Value = usu_perfil_acesso;


                comando.Parameters.Add(pusu_codigo);
                comando.Parameters.Add(pusu_nome);
                comando.Parameters.Add(pusu_login);
                comando.Parameters.Add(pusu_senha);
                comando.Parameters.Add(pusu_status);
                comando.Parameters.Add(pusu_perfil_acesso);
                return comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Alterar Usuario:" + ex.Message);
            }

        }


        public int ExcluirUsuario(string procedure, int usu_codigo)
        {

            try
            {
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pusu_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                pusu_codigo.Value = usu_codigo;

                comando.Parameters.Add(pusu_codigo);
                return comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Excluir Usuario:" + ex.Message);
            }

        }

    }
}
