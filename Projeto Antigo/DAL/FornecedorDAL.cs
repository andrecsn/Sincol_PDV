using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SincolPDV.DAL
{
    public class FornecedorDAL
    {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public FornecedorDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }

        public DataTable ConsultaFornecedor(string procedure, int campo)
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

        public void DeletarFornecedor(string procedure, string descricao)
        {

            try
            {

                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;
                SqlParameter pfiltro = new SqlParameter("@codigo", SqlDbType.Text);
                pfiltro.Value = descricao;
                comando.Parameters.Add(pfiltro);
                comando.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao deletar Fornecedor:" + ex.Number);
            }

        }


        public int InserirFornecedor(string procedure, string forn_nome, int forn_status, string forn_tp_pessoa, string forn_cpf,
            string forn_cnpj, string forn_telefone, string forn_endereco, string forn_email, string forn_dados_bancarios, string forn_observacao)
        {

            try
            {
                int result;
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pforn_nome = new SqlParameter("@nome", SqlDbType.Text);
                pforn_nome.Value = forn_nome;
                SqlParameter pforn_tp_pessoa = new SqlParameter("@tp_pessoa", SqlDbType.Char);
                pforn_tp_pessoa.Value = forn_tp_pessoa;
                SqlParameter pforn_cpf = new SqlParameter("@cpf", SqlDbType.Text);
                pforn_cpf.Value = forn_cpf;
                SqlParameter pforn_cnpj = new SqlParameter("@cnpj", SqlDbType.Text);
                pforn_cnpj.Value = forn_cnpj;
                SqlParameter pforn_telefone = new SqlParameter("@telefone", SqlDbType.Text);
                pforn_telefone.Value = forn_telefone;
                SqlParameter pforn_endereco = new SqlParameter("@endereco", SqlDbType.Text);
                pforn_endereco.Value = forn_endereco;
                SqlParameter pforn_email = new SqlParameter("@email", SqlDbType.Text);
                pforn_email.Value = forn_email;
                SqlParameter pforn_status = new SqlParameter("@status", SqlDbType.Int);
                pforn_status.Value = forn_status;
                SqlParameter pforn_dados_bancarios = new SqlParameter("@dados_bancarios", SqlDbType.Text);
                pforn_dados_bancarios.Value = forn_dados_bancarios;
                SqlParameter pforn_observacao = new SqlParameter("@observacao", SqlDbType.Text);
                pforn_observacao.Value = forn_observacao;


                comando.Parameters.Add(pforn_nome);
                comando.Parameters.Add(pforn_tp_pessoa);
                comando.Parameters.Add(pforn_cpf);
                comando.Parameters.Add(pforn_cnpj);
                comando.Parameters.Add(pforn_telefone);
                comando.Parameters.Add(pforn_endereco);
                comando.Parameters.Add(pforn_email);
                comando.Parameters.Add(pforn_status);
                comando.Parameters.Add(pforn_dados_bancarios);
                comando.Parameters.Add(pforn_observacao);
                return result = comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir Fornecedor:" + ex.Message);
            }

        }



        public int AlterarFornecedor(string procedure, int forn_codigo, string forn_nome, int forn_status, string forn_tp_pessoa, string forn_cpf,
            string forn_cnpj, string forn_telefone, string forn_endereco, string forn_email, string forn_dados_bancarios, string forn_observacao)
        {

            try
            {

                int result;
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pforn_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                pforn_codigo.Value = forn_codigo;
                SqlParameter pforn_nome = new SqlParameter("@nome", SqlDbType.Text);
                pforn_nome.Value = forn_nome;
                SqlParameter pforn_tp_pessoa = new SqlParameter("@tp_pessoa", SqlDbType.Char);
                pforn_tp_pessoa.Value = forn_tp_pessoa;
                SqlParameter pforn_cpf = new SqlParameter("@cpf", SqlDbType.Text);
                pforn_cpf.Value = forn_cpf;
                SqlParameter pforn_cnpj = new SqlParameter("@cnpj", SqlDbType.Text);
                pforn_cnpj.Value = forn_cnpj;
                SqlParameter pforn_telefone = new SqlParameter("@telefone", SqlDbType.Text);
                pforn_telefone.Value = forn_telefone;
                SqlParameter pforn_endereco = new SqlParameter("@endereco", SqlDbType.Text);
                pforn_endereco.Value = forn_endereco;
                SqlParameter pforn_email = new SqlParameter("@email", SqlDbType.Text);
                pforn_email.Value = forn_email;
                SqlParameter pforn_status = new SqlParameter("@status", SqlDbType.Int);
                pforn_status.Value = forn_status;
                SqlParameter pforn_dados_bancarios = new SqlParameter("@dados_bancarios", SqlDbType.Text);
                pforn_dados_bancarios.Value = forn_dados_bancarios;
                SqlParameter pforn_observacao = new SqlParameter("@observacao", SqlDbType.Text);
                pforn_observacao.Value = forn_observacao;



                comando.Parameters.Add(pforn_codigo);
                comando.Parameters.Add(pforn_nome);
                comando.Parameters.Add(pforn_tp_pessoa);
                comando.Parameters.Add(pforn_cpf);
                comando.Parameters.Add(pforn_cnpj);
                comando.Parameters.Add(pforn_telefone);
                comando.Parameters.Add(pforn_endereco);
                comando.Parameters.Add(pforn_email);
                comando.Parameters.Add(pforn_status);
                comando.Parameters.Add(pforn_dados_bancarios);
                comando.Parameters.Add(pforn_observacao);
                return result = comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Alterar Fornecedor:" + ex.Message);
            }

        }


        public int ExcluirForncedor(string procedure, int forn_codigo)
        {

            try
            {
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pforn_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                pforn_codigo.Value = forn_codigo;

                comando.Parameters.Add(pforn_codigo);
                return comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Excluir Fornecedor:" + ex.Message);
            }

        }


        public DataTable ListarFornecedor(string procedure, int codigo, string nome, string cpf, string telefone)
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.Text);
            pfiltro.Value = codigo;
            pfiltro = oda.SelectCommand.Parameters.Add("@nome", SqlDbType.Text);
            pfiltro.Value = nome;
            pfiltro = oda.SelectCommand.Parameters.Add("@cpf", SqlDbType.Text);
            pfiltro.Value = cpf;
            pfiltro = oda.SelectCommand.Parameters.Add("@telefone", SqlDbType.Text);
            pfiltro.Value = telefone;
            oda.Fill(i);

            return i;
        }


    }
}