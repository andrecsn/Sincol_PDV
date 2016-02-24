using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SincolPDV.DAL
{
    public class ProdutoDAL
    {
        string conexao = ConfigurationManager.ConnectionStrings["context"].ConnectionString.ToString();
        private SqlConnection _conn;
        private SqlCommand comando;
        private SqlDataAdapter oda;

        public ProdutoDAL()
        {
            _conn = new SqlConnection(conexao);
            _conn.Open();

        }

        public DataTable ConsultaProduto(string procedure, string descricao)
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@referencia", SqlDbType.Text);
            pfiltro.Value = descricao;
            oda.Fill(i);



            return i;
        }

        public int ExcluirProdutos(string procedure, int codigo)
        {

            try
            {
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pclie_codigo = new SqlParameter("@codigo", SqlDbType.Int);
                pclie_codigo.Value = codigo;

                comando.Parameters.Add(pclie_codigo);
                return comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Excluir Produto:" + ex.Message);
            }

        }

        public int InserirProduto(string procedure, string prod_referencia, string prod_descricao, string prod_status, string prod_marca, int prod_fabricante, string prod_modelo, string prod_imagem, string prod_unidade_entrada, int prod_fator, string prod_unidade_saida, decimal prod_preco_untario, int prod_estoque_maximo, int prod_estoque_minimo, decimal prod_valor_tabela, string prod_observacao, int prod_tipo_saida, string prod_origem, string prod_peso)
        {

            try
            {
                int result;
                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;
                SqlParameter pprod_fabricante = new SqlParameter("@cod_fabricante", SqlDbType.Int);
                pprod_fabricante.Value = prod_fabricante;
                SqlParameter pprod_referencia = new SqlParameter("@referencia", SqlDbType.Text);
                pprod_referencia.Value = prod_referencia;
                SqlParameter pprod_descricao = new SqlParameter("@descricao", SqlDbType.Text);
                pprod_descricao.Value = prod_descricao;
                SqlParameter pprod_status = new SqlParameter("@status", SqlDbType.Text);
                pprod_status.Value = prod_status;
                SqlParameter pprod_marca = new SqlParameter("@marca", SqlDbType.Text);
                pprod_marca.Value = prod_marca;
                SqlParameter pprod_modelo = new SqlParameter("@modelo", SqlDbType.Text);
                pprod_modelo.Value = prod_modelo;
                //SqlParameter pprod_imagem = new SqlParameter("@imagem", SqlDbType.Text);
                //pprod_imagem.Value = prod_imagem;
                SqlParameter pprod_unidade_entrada = new SqlParameter("@unidade_entrada", SqlDbType.Text);
                pprod_unidade_entrada.Value = prod_unidade_entrada;
                SqlParameter pprod_fator = new SqlParameter("@fator", SqlDbType.Int);
                pprod_fator.Value = prod_fator;
                SqlParameter pprod_unidade_saida = new SqlParameter("@unidade_saida", SqlDbType.Text);
                pprod_unidade_saida.Value = prod_unidade_saida;
                SqlParameter pprod_preco_unitario = new SqlParameter("@preco_unitario", SqlDbType.Decimal);
                pprod_preco_unitario.Value = prod_preco_untario;
                SqlParameter pprod_estoque_maximo = new SqlParameter("@estoque_maximo", SqlDbType.Int);
                pprod_estoque_maximo.Value = prod_estoque_maximo;
                SqlParameter pprod_estoque_minimo = new SqlParameter("@estoque_minimo", SqlDbType.Int);
                pprod_estoque_minimo.Value = prod_estoque_minimo;
                SqlParameter pprod_valor_tabela = new SqlParameter("@valor_tabela", SqlDbType.Decimal);
                pprod_valor_tabela.Value = prod_valor_tabela;
                SqlParameter pprod_observacao = new SqlParameter("@observacao", SqlDbType.Text);
                pprod_observacao.Value = prod_observacao;
                SqlParameter pprod_tipo_saida = new SqlParameter("@tipo_saida", SqlDbType.Int);
                pprod_tipo_saida.Value = prod_tipo_saida;
                SqlParameter pprod_origem = new SqlParameter("@origem", SqlDbType.Text);
                pprod_origem.Value = prod_origem;
                SqlParameter pprod_peso = new SqlParameter("@peso", SqlDbType.Text);
                pprod_peso.Value = prod_peso;


                comando.Parameters.Add(pprod_fabricante);
                comando.Parameters.Add(pprod_referencia);
                comando.Parameters.Add(pprod_descricao);
                comando.Parameters.Add(pprod_status);
                comando.Parameters.Add(pprod_marca);
                comando.Parameters.Add(pprod_modelo);
                //comando.Parameters.Add(pprod_imagem);
                comando.Parameters.Add(pprod_unidade_entrada);
                comando.Parameters.Add(pprod_fator);
                comando.Parameters.Add(pprod_unidade_saida);
                comando.Parameters.Add(pprod_preco_unitario);
                comando.Parameters.Add(pprod_estoque_maximo);
                comando.Parameters.Add(pprod_estoque_minimo);
                comando.Parameters.Add(pprod_valor_tabela);
                comando.Parameters.Add(pprod_observacao);
                comando.Parameters.Add(pprod_tipo_saida);
                comando.Parameters.Add(pprod_origem);
                comando.Parameters.Add(pprod_peso);
              return result = comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir Produto:" + ex.Message);
            }

        }

        public int AlterarProduto(string procedure, int prod_codigo, string prod_referencia, string prod_descricao, string prod_status, string prod_marca, int prod_fabricante, string prod_modelo, string prod_imagem, string prod_unidade_entrada, int prod_fator, string prod_unidade_saida, decimal prod_preco_untario, int prod_estoque_maximo, int prod_estoque_minimo, decimal prod_valor_tabela, string prod_observacao, int prod_tipo_saida, string prod_origem, string prod_peso)
        {

            try
            {

                comando = new SqlCommand();
                comando.Connection = _conn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = procedure;

                SqlParameter pprod_codigo = new SqlParameter("@cod_codigo", SqlDbType.Int);
                pprod_codigo.Value = prod_codigo;
                SqlParameter pprod_fabricante = new SqlParameter("@cod_fabricante", SqlDbType.Int);
                pprod_fabricante.Value = prod_fabricante;
                SqlParameter pprod_referencia = new SqlParameter("@referencia", SqlDbType.Text);
                pprod_referencia.Value = prod_referencia;
                SqlParameter pprod_descricao = new SqlParameter("@descricao", SqlDbType.Text);
                pprod_descricao.Value = prod_descricao;
                SqlParameter pprod_status = new SqlParameter("@status", SqlDbType.Text);
                pprod_status.Value = prod_status;
                SqlParameter pprod_marca = new SqlParameter("@marca", SqlDbType.Text);
                pprod_marca.Value = prod_marca;
                SqlParameter pprod_modelo = new SqlParameter("@modelo", SqlDbType.Text);
                pprod_modelo.Value = prod_modelo;
                //SqlParameter pprod_imagem = new SqlParameter("@imagem", SqlDbType.Text);
                //pprod_imagem.Value = prod_imagem;
                SqlParameter pprod_unidade_entrada = new SqlParameter("@unidade_entrada", SqlDbType.Text);
                pprod_unidade_entrada.Value = prod_unidade_entrada;
                SqlParameter pprod_fator = new SqlParameter("@fator", SqlDbType.Int);
                pprod_fator.Value = prod_fator;
                SqlParameter pprod_unidade_saida = new SqlParameter("@unidade_saida", SqlDbType.Text);
                pprod_unidade_saida.Value = prod_unidade_saida;
                SqlParameter pprod_preco_unitario = new SqlParameter("@preco_unitario", SqlDbType.Decimal);
                pprod_preco_unitario.Value = prod_preco_untario;
                SqlParameter pprod_estoque_maximo = new SqlParameter("@estoque_maximo", SqlDbType.Int);
                pprod_estoque_maximo.Value = prod_estoque_maximo;
                SqlParameter pprod_estoque_minimo = new SqlParameter("@estoque_minimo", SqlDbType.Int);
                pprod_estoque_minimo.Value = prod_estoque_minimo;
                SqlParameter pprod_valor_tabela = new SqlParameter("@valor_tabela", SqlDbType.Decimal);
                pprod_valor_tabela.Value = prod_valor_tabela;
                SqlParameter pprod_observacao = new SqlParameter("@observacao", SqlDbType.Text);
                pprod_observacao.Value = prod_observacao;
                SqlParameter pprod_tipo_saida = new SqlParameter("@tipo_saida", SqlDbType.Int);
                pprod_tipo_saida.Value = prod_tipo_saida;
                SqlParameter pprod_origem = new SqlParameter("@origem", SqlDbType.Text);
                pprod_origem.Value = prod_origem;
                SqlParameter pprod_peso = new SqlParameter("@peso", SqlDbType.Text);
                pprod_peso.Value = prod_peso;

                comando.Parameters.Add(pprod_codigo);
                comando.Parameters.Add(pprod_fabricante);
                comando.Parameters.Add(pprod_referencia);
                comando.Parameters.Add(pprod_descricao);
                comando.Parameters.Add(pprod_status);
                comando.Parameters.Add(pprod_marca);
                comando.Parameters.Add(pprod_modelo);
                //comando.Parameters.Add(pprod_imagem);
                comando.Parameters.Add(pprod_unidade_entrada);
                comando.Parameters.Add(pprod_fator);
                comando.Parameters.Add(pprod_unidade_saida);
                comando.Parameters.Add(pprod_preco_unitario);
                comando.Parameters.Add(pprod_estoque_maximo);
                comando.Parameters.Add(pprod_estoque_minimo);
                comando.Parameters.Add(pprod_valor_tabela);
                comando.Parameters.Add(pprod_observacao);
                comando.Parameters.Add(pprod_tipo_saida);
                comando.Parameters.Add(pprod_origem);
                comando.Parameters.Add(pprod_peso);
                return comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw new Exception("Erro ao Alterar Produto:" + ex.Message);
            }

        }

        public DataTable ListarProduto(string procedure, string referencia, string descricao, string origem, int fabricante, string modelo, string marca )
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@referencia", SqlDbType.Text);
            pfiltro.Value = referencia;
            pfiltro = oda.SelectCommand.Parameters.Add("@descricao", SqlDbType.Text);
            pfiltro.Value = descricao;
            pfiltro = oda.SelectCommand.Parameters.Add("@origem", SqlDbType.Text);
            pfiltro.Value = origem;
            pfiltro = oda.SelectCommand.Parameters.Add("@fabricante", SqlDbType.Int);
            pfiltro.Value = fabricante;
            pfiltro = oda.SelectCommand.Parameters.Add("@modelo", SqlDbType.Text);
            pfiltro.Value = modelo;
            pfiltro = oda.SelectCommand.Parameters.Add("@marca", SqlDbType.Text);
            pfiltro.Value = marca;
            oda.Fill(i);

            return i;
        }


        public DataTable ListarProduto_Movimentacao(string procedure, string movimentacao, string referencia, string descricao, string dataInicio, string dataFinal, string entrada, string saida, string emprestimo)
        {

            DataTable i = new DataTable();
            SqlParameter pfiltro;
            oda = new SqlDataAdapter();
            oda.SelectCommand = new SqlCommand();
            oda.SelectCommand.CommandText = procedure;
            oda.SelectCommand.Connection = _conn;
            oda.SelectCommand.CommandType = CommandType.StoredProcedure;

            pfiltro = oda.SelectCommand.Parameters.Add("@movimentacao", SqlDbType.Text);
            pfiltro.Value = movimentacao;
            pfiltro = oda.SelectCommand.Parameters.Add("@referencia", SqlDbType.Text);
            pfiltro.Value = referencia;
            pfiltro = oda.SelectCommand.Parameters.Add("@descricao", SqlDbType.Text);
            pfiltro.Value = descricao;
            pfiltro = oda.SelectCommand.Parameters.Add("@dataInicio", SqlDbType.Text);
            pfiltro.Value = dataInicio;
            pfiltro = oda.SelectCommand.Parameters.Add("@dataFinal", SqlDbType.Text);
            pfiltro.Value = dataFinal;
            pfiltro = oda.SelectCommand.Parameters.Add("@entrada", SqlDbType.Text);
            pfiltro.Value = entrada;
            pfiltro = oda.SelectCommand.Parameters.Add("@saida", SqlDbType.Text);
            pfiltro.Value = saida;
            pfiltro = oda.SelectCommand.Parameters.Add("@emprestimo", SqlDbType.Text);
            pfiltro.Value = emprestimo;

            oda.Fill(i);

            return i;
        }
    }
}
