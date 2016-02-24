using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SincolPDV.DAL
{
    public class ClienteDAL
   {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public ClienteDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }

        public DataTable ConsultaCliente(string procedure, int campo)
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


        public int InserirCliente(string procedure, string clie_nome, string clie_tp_pessoa, int clie_status, string clie_cpf,
            string clie_cnpj, string clie_telefone, string clie_endereco, string clie_sexo, DateTime clie_dt_nascimento,
            string clie_email, DateTime clie_dt_cadastro, DateTime clie_dt_atualizacao, decimal clie_limite_credito, int clie_qtd_dias_credito,
            string clie_observacao)
        {

            try
            {
                int result;
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pclie_nome = new SqlParameter("@nome", SqlDbType.Text);
                pclie_nome.Value = clie_nome;
                SqlParameter pclie_tp_pessoa = new SqlParameter("@tp_pessoa", SqlDbType.Char);
                pclie_tp_pessoa.Value = clie_tp_pessoa;
                SqlParameter pclie_cpf = new SqlParameter("@cpf", SqlDbType.Text);
                pclie_cpf.Value = clie_cpf;
                SqlParameter pclie_cnpj = new SqlParameter("@cnpj", SqlDbType.Text);
                pclie_cnpj.Value = clie_cnpj;
                SqlParameter pclie_telefone = new SqlParameter("@telefone", SqlDbType.Text);
                pclie_telefone.Value = clie_telefone;
                //SqlParameter pprod_imagem = new SqlParameter("@imagem", SqlDbType.Text);
                //pprod_imagem.Value = prod_imagem;
                SqlParameter pclie_endereco= new SqlParameter("@endereco", SqlDbType.Text);
                pclie_endereco.Value = clie_endereco;
                SqlParameter pclie_sexo = new SqlParameter("@sexo", SqlDbType.Text);
                pclie_sexo.Value = clie_sexo;
                SqlParameter pclie_dt_nascimento = new SqlParameter("@dt_nasc", SqlDbType.DateTime);
                pclie_dt_nascimento.Value = clie_dt_nascimento;
                SqlParameter pclie_email = new SqlParameter("@email", SqlDbType.Text);
                pclie_email.Value = clie_email;
                SqlParameter pclie_status= new SqlParameter("@status", SqlDbType.Int);
                pclie_status.Value = clie_status;
                SqlParameter pclie_dt_cadastro = new SqlParameter("@dt_cadastro", SqlDbType.DateTime);
                pclie_dt_cadastro.Value = clie_dt_cadastro;
                SqlParameter pclie_dt_atualizacao = new SqlParameter("@dt_atualizacao", SqlDbType.DateTime);
                pclie_dt_atualizacao.Value = clie_dt_atualizacao;
                SqlParameter pclie_limite_credito = new SqlParameter("@limite_credito", SqlDbType.Decimal);
                pclie_limite_credito.Value = clie_limite_credito;
                SqlParameter pclie_qtd_dias_credito = new SqlParameter("@qtd_dias_emprestimo", SqlDbType.Int);
                pclie_qtd_dias_credito.Value = clie_qtd_dias_credito;
                SqlParameter pclie_observacao = new SqlParameter("@observacao", SqlDbType.Text);
                pclie_observacao.Value = clie_observacao;


                comando.Parameters.Add(pclie_nome);
                comando.Parameters.Add(pclie_tp_pessoa);
                comando.Parameters.Add(pclie_cpf);
                comando.Parameters.Add(pclie_cnpj);
                comando.Parameters.Add(pclie_telefone);
                //comando.Parameters.Add(pprod_imagem);
                comando.Parameters.Add(pclie_endereco);
                comando.Parameters.Add(pclie_sexo);
                comando.Parameters.Add(pclie_dt_nascimento);
                comando.Parameters.Add(pclie_email);
                comando.Parameters.Add(pclie_status);
                comando.Parameters.Add(pclie_dt_cadastro);
                comando.Parameters.Add(pclie_dt_atualizacao);
                comando.Parameters.Add(pclie_limite_credito);
                comando.Parameters.Add(pclie_qtd_dias_credito);
                comando.Parameters.Add(pclie_observacao);
                return result = comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir Cliente:" + ex.Message);
            }

        }



        public int AlterarCliente(string procedure, int clie_codigo, string clie_nome, string clie_tp_pessoa, int clie_status, string clie_cpf,
            string clie_cnpj, string clie_telefone, string clie_endereco, string clie_sexo, DateTime clie_dt_nascimento,
            string clie_email, DateTime clie_dt_cadastro, DateTime clie_dt_atualizacao, decimal clie_limite_credito, int clie_qtd_dias_credito, 
            string clie_observacao)
        {

            try
            {

                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pclie_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                pclie_codigo.Value = clie_codigo;
                SqlParameter pclie_nome = new SqlParameter("@nome", SqlDbType.Text);
                pclie_nome.Value = clie_nome;
                SqlParameter pclie_tp_pessoa = new SqlParameter("@tp_pessoa", SqlDbType.Char);
                pclie_tp_pessoa.Value = clie_tp_pessoa;
                SqlParameter pclie_cpf = new SqlParameter("@cpf", SqlDbType.Text);
                pclie_cpf.Value = clie_cpf;
                SqlParameter pclie_cnpj = new SqlParameter("@cnpj", SqlDbType.Text);
                pclie_cnpj.Value = clie_cnpj;
                SqlParameter pclie_telefone = new SqlParameter("@telefone", SqlDbType.Text);
                pclie_telefone.Value = clie_telefone;
                //SqlParameter pprod_imagem = new SqlParameter("@imagem", SqlDbType.Text);
                //pprod_imagem.Value = prod_imagem;
                SqlParameter pclie_endereco = new SqlParameter("@endereco", SqlDbType.Text);
                pclie_endereco.Value = clie_endereco;
                SqlParameter pclie_sexo = new SqlParameter("@sexo", SqlDbType.Text);
                pclie_sexo.Value = clie_sexo;
                SqlParameter pclie_dt_nascimento = new SqlParameter("@dt_nasc", SqlDbType.DateTime);
                pclie_dt_nascimento.Value = clie_dt_nascimento;
                SqlParameter pclie_email = new SqlParameter("@email", SqlDbType.Text);
                pclie_email.Value = clie_email;
                SqlParameter pclie_status = new SqlParameter("@status", SqlDbType.Int);
                pclie_status.Value = clie_status;
                SqlParameter pclie_dt_cadastro = new SqlParameter("@dt_cadastro", SqlDbType.DateTime);
                pclie_dt_cadastro.Value = clie_dt_cadastro;
                SqlParameter pclie_dt_atualizacao = new SqlParameter("@dt_atualizacao", SqlDbType.DateTime);
                pclie_dt_atualizacao.Value = clie_dt_atualizacao;
                SqlParameter pclie_limite_credito = new SqlParameter("@limite_credito", SqlDbType.Decimal);
                pclie_limite_credito.Value = clie_limite_credito;
                SqlParameter pclie_qtd_dias_credito = new SqlParameter("@qtd_dias_emprestimo", SqlDbType.Int);
                pclie_qtd_dias_credito.Value = clie_qtd_dias_credito;
                SqlParameter pclie_observacao = new SqlParameter("@observacao", SqlDbType.Text);
                pclie_observacao.Value = clie_observacao;


                comando.Parameters.Add(pclie_codigo);
                comando.Parameters.Add(pclie_nome);
                comando.Parameters.Add(pclie_tp_pessoa);
                comando.Parameters.Add(pclie_cpf);
                comando.Parameters.Add(pclie_cnpj);
                comando.Parameters.Add(pclie_telefone);
                //comando.Parameters.Add(pprod_imagem);
                comando.Parameters.Add(pclie_endereco);
                comando.Parameters.Add(pclie_sexo);
                comando.Parameters.Add(pclie_dt_nascimento);
                comando.Parameters.Add(pclie_email);
                comando.Parameters.Add(pclie_status);
                comando.Parameters.Add(pclie_dt_cadastro);
                comando.Parameters.Add(pclie_dt_atualizacao);
                comando.Parameters.Add(pclie_limite_credito);
                comando.Parameters.Add(pclie_qtd_dias_credito);
                comando.Parameters.Add(pclie_observacao);
                return comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Alterar Cliente:" + ex.Message);
            }

        }


        public int ExcluirCliente(string procedure, int clie_codigo)
        {

            try
            {
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pclie_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                pclie_codigo.Value = clie_codigo;

                comando.Parameters.Add(pclie_codigo);
                return comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Excluir Cliente:" + ex.Message);
            }

        }


        public DataTable ListarCliente(string procedure, int codigo, string nome, string cpf, string telefone)
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