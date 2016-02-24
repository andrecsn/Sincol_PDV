using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SincolPDV.DAL
{
    public class Perfil_AcessoDAL
    {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public Perfil_AcessoDAL ()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }


        public DataTable ConsultaPerfilAcesso(string procedure, string descricao)
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@descricao", SqlDbType.Text);
            pfiltro.Value = descricao;
            oda.Fill(i);

            return i;
        }

        public int CadastrarPerfilTransacao (string procedure, int tran_codigo, int pera_codigo, int pert_consultar, int pert_visualizar, int pert_excluir, int pert_alterar, int pert_incluir, int pert_imprimir, int pert_processar, int pert_liberar)
        {
             try
            {
                int result;
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;
                SqlParameter ttran_codigo = new SqlParameter("@cd_transacao", SqlDbType.Int);
                ttran_codigo.Value = tran_codigo;
                SqlParameter ppert_consultar = new SqlParameter("@consultar", SqlDbType.Int);
                ppert_consultar.Value = pert_consultar;
                SqlParameter ppert_excluir = new SqlParameter("@excluir", SqlDbType.Int);
                ppert_excluir.Value = pert_excluir;
                SqlParameter ppert_alterar = new SqlParameter("@alterar", SqlDbType.Int);
                ppert_alterar.Value = pert_alterar;
                SqlParameter ppert_incluir = new SqlParameter("@incluir", SqlDbType.Int);
                ppert_incluir.Value = pert_incluir;
                SqlParameter ppert_imprimir = new SqlParameter("@imprimir", SqlDbType.Int);
                ppert_imprimir.Value = pert_imprimir;
                SqlParameter ppert_processar = new SqlParameter("@processar", SqlDbType.Int);
                ppert_processar.Value = pert_processar;
                SqlParameter ppert_visualizar = new SqlParameter("@visualizar", SqlDbType.Int);
                ppert_visualizar.Value = pert_visualizar;
                SqlParameter ppert_liberar = new SqlParameter("@liberar", SqlDbType.Int);
                ppert_liberar.Value = pert_liberar;
                SqlParameter ppera_codigo = new SqlParameter("@cd_perfil_acesso", SqlDbType.Int);
                ppera_codigo.Value = pera_codigo;
                
                comando.Parameters.Add(ttran_codigo);
                comando.Parameters.Add(ppert_consultar);
                comando.Parameters.Add(ppert_excluir);
                comando.Parameters.Add(ppert_alterar);
                comando.Parameters.Add(ppert_incluir);
                comando.Parameters.Add(ppert_imprimir);
                comando.Parameters.Add(ppert_processar);
                comando.Parameters.Add(ppert_visualizar);
                comando.Parameters.Add(ppert_liberar);
                comando.Parameters.Add(ppera_codigo);
                
              return result = comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir Perfil Transação:" + ex.Message);
            }

        }

        public DataTable ConsultaPerfilTransacao(string procedure)
        {

            DataTable i = new DataTable();
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;
            oda.Fill(i);

            return i;
        }
        }
    }

