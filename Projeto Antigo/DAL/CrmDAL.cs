using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SincolPDV.DAL
{
    public class CrmDAL
    {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public CrmDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }


        public int InserirCRM(string procedure, string descricao, string select_clie_forn, int clie_forn_codigo,
        string clie_forn_nome, string assunto, string texto, string status_resposta, string data_resposta, string resposta, string data)
        {

            try
            {
                int result;
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pcrm_descricao = new SqlParameter("@descricao", SqlDbType.Text);
                pcrm_descricao.Value = descricao;
                SqlParameter pcrm_select_clie_forn = new SqlParameter("@select_clie_forn", SqlDbType.Text);
                pcrm_select_clie_forn.Value = select_clie_forn;
                SqlParameter pcrm_clie_forn_codigo = new SqlParameter("@clie_forn_codigo", SqlDbType.Int);
                pcrm_clie_forn_codigo.Value = clie_forn_codigo;
                SqlParameter pcrm_clie_forn_nome = new SqlParameter("@clie_forn_nome", SqlDbType.Text);
                pcrm_clie_forn_nome.Value = clie_forn_nome;
                SqlParameter pcrm_assunto = new SqlParameter("@assunto", SqlDbType.Text);
                pcrm_assunto.Value = assunto;
                SqlParameter pcrm_texto = new SqlParameter("@texto", SqlDbType.Text);
                pcrm_texto.Value = texto;
                SqlParameter pcrm_status_resposta = new SqlParameter("@status_resposta", SqlDbType.Text);
                pcrm_status_resposta.Value = status_resposta;
                SqlParameter pcrm_data_resposta = new SqlParameter("@data_resposta", SqlDbType.DateTime);
                pcrm_data_resposta.Value = data_resposta;
                SqlParameter pcrm_resposta = new SqlParameter("@resposta", SqlDbType.Text);
                pcrm_resposta.Value = resposta;
                SqlParameter pcrm_data = new SqlParameter("@data", SqlDbType.DateTime);
                pcrm_data.Value = data;


                comando.Parameters.Add(pcrm_descricao);
                comando.Parameters.Add(pcrm_select_clie_forn);
                comando.Parameters.Add(pcrm_clie_forn_codigo);
                comando.Parameters.Add(pcrm_clie_forn_nome);
                comando.Parameters.Add(pcrm_assunto);
                comando.Parameters.Add(pcrm_texto);
                comando.Parameters.Add(pcrm_status_resposta);
                comando.Parameters.Add(pcrm_data_resposta);
                comando.Parameters.Add(pcrm_resposta);
                comando.Parameters.Add(pcrm_data);

                return result = comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir CRM:" + ex.Message);
            }

        }


        public DataTable ListarCRM(string procedure, int codigo, string descricao, string select_clie_forn, string clie_forn_nome)
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.Int);
            pfiltro.Value = codigo;
            pfiltro = oda.SelectCommand.Parameters.Add("@descricao", SqlDbType.Text);
            pfiltro.Value = descricao;
            pfiltro = oda.SelectCommand.Parameters.Add("@select_clie_forn", SqlDbType.Text);
            pfiltro.Value = select_clie_forn;
            pfiltro = oda.SelectCommand.Parameters.Add("@clie_forn_nome", SqlDbType.Text);
            pfiltro.Value = clie_forn_nome;
            
            oda.Fill(i);

            return i;
        }


    }
}
