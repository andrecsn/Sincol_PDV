using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;


namespace SincolPDV.BLL
{      
    public class Produto
    {


        #region atributos

        int codigo;
        string referencia;
        string nome;
        string descricao;
        string status;
        string marca;
        string modelo;
        int fabricante;
        string imagem;
        string unEntrada;
        int fator;
        string unSaida;
        decimal precoUnitario;
        int estMinimo;
        int estMaximo;
        decimal vlTabela;
        string observacao;
        int tpsaida;
        string origem;
        string peso;

        string dataInicio;
        string dataFinal;
        string entrada;
        string saida;
        string emprestimo;


        #endregion

        #region Propriedades

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }

        public string UnEntrada
        {
            get { return unEntrada; }
            set { unEntrada = value; }
        }

        public int Fator
        {
            get { return fator; }
            set { fator = value; }
        }

        public string UnSaida
        {
            get { return unSaida; }
            set { unSaida = value; }
        }

        public decimal PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public int EstMinimo
        {
            get { return estMinimo; }
            set { estMinimo = value; }
        }

        public int EstMaximo
        {
            get { return estMaximo; }
            set { estMaximo = value; }
        }

        public decimal VlTabela
        {
            get { return vlTabela; }
            set { vlTabela = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public int Tpsaida
        {
            get { return tpsaida; }
            set { tpsaida = value; }
        }

        public string Origem
        {
            get { return origem; }
            set { origem = value; }
        }

        public string Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public string DataFinal
        {
            get { return dataFinal; }
            set { dataFinal = value; }
        }

        public string Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        public string Saida
        {
            get { return saida; }
            set { saida = value; }
        }

        public string Emprestimo
        {
            get { return emprestimo; }
            set { emprestimo = value; }
        }

        #endregion

        #region Metodos
        ProdutoDAL prod = new ProdutoDAL();
        Acesso exe = new Acesso();
        int result;


        public int CadastrarProduto()
        {
            return result = prod.InserirProduto("P_CADASTRAR_PRODUTO", Referencia, Descricao, Status, Marca, Fabricante, Modelo, Imagem, UnEntrada, Fator, UnSaida, PrecoUnitario, EstMaximo, EstMinimo, VlTabela, Observacao, Tpsaida, Origem, Peso);
        }

        public int AlterarProduto()
        {
            return result = prod.AlterarProduto("P_ALTERAR_PRODUTO", Codigo, Referencia, Descricao, Status, Marca, Fabricante, Modelo, Imagem, UnEntrada, Fator, UnSaida, PrecoUnitario, EstMaximo, EstMinimo, VlTabela, Observacao, Tpsaida, Origem, Peso);
        }

        public int ExcluirProduto()
        {
            return result = prod.ExcluirProdutos("P_DELETAR_PRODUTO", Codigo);
        }

        public void InserirObservacao()
        {
            exe.Executar("update Produto set Prod_Descricao =" + Descricao + "Prod_Observacao = " + Observacao +
                          "Where Prod_Referencia = " + Referencia);
        }

        public int Consulta()
        {

            ProdutoDAL Prod = new ProdutoDAL();
            DataTable dt =  Prod.ConsultaProduto("P_CONSULTAR_LISTA_PRODUTO_POR_REFERENCIA", Referencia);
            
            if (dt.Rows.Count > 0)
            {
                
                Codigo = Convert.ToInt32( dt.Rows[0]["PROD_CODIGO"].ToString());
                Referencia = dt.Rows[0]["PROD_REFERENCIA"].ToString();
                Nome = dt.Rows[0]["PROD_NOME"].ToString();
                Descricao = dt.Rows[0]["PROD_DESCRICAO"].ToString();
                Status = dt.Rows[0]["PROD_STATUS"].ToString();
                Marca =  TrataNulo(dt.Rows[0]["PROD_MARCA"].ToString(), "");
                Modelo = dt.Rows[0]["PROD_MODELO"].ToString();
                Fabricante = Convert.ToInt32(dt.Rows[0]["FAB_CODIGO"].ToString());
                Imagem = dt.Rows[0]["PROD_IMAGEM"].ToString();
                UnEntrada = dt.Rows[0]["PROD_UNIDADE_ENTRADA"].ToString();
                Fator = Convert.ToInt32(dt.Rows[0]["PROD_FATOR"].ToString());
                UnSaida = dt.Rows[0]["PROD_UNIDADE_SAIDA"].ToString();

                EstMinimo = 0;
                if (dt.Rows[0]["PROD_ESTOQUE_MINIMO"].ToString() != "")
                {
                    EstMinimo = Convert.ToInt32(dt.Rows[0]["PROD_ESTOQUE_MINIMO"].ToString());
                }
                EstMaximo = 0;
                if (dt.Rows[0]["PROD_ESTOQUE_MAXIMO"].ToString() != "")
                {
                    EstMaximo = Convert.ToInt32(dt.Rows[0]["PROD_ESTOQUE_MAXIMO"].ToString());
                }

                PrecoUnitario = 0;
                if (dt.Rows[0]["PROD_PRECO_UNITARIO"].ToString() != "")
                {
                    PrecoUnitario = decimal.Parse(dt.Rows[0]["PROD_PRECO_UNITARIO"].ToString());
                }
                Observacao = dt.Rows[0]["PROD_OBSERVACAO"].ToString();

                Tpsaida = 0;
                if (dt.Rows[0]["PROD_VALOR_TABELA"].ToString() != "")
                {
                    Tpsaida = Convert.ToInt32(dt.Rows[0]["PROD_TIPO_SAIDA"].ToString());
                }
                Origem = dt.Rows[0]["PROD_ORIGEM"].ToString();
                Peso = dt.Rows[0]["PROD_PESO"].ToString();

                return 1;
            }
            return 0;
        }

        public DataTable ListarProduto()
        {
            return prod.ListarProduto("P_CONSULTAR_LISTA_PRODUTO", Referencia, Descricao, Origem, Fabricante, Modelo, Marca);
            
        }


        public DataTable ListarProduto_Movimentacao()
        {
            return prod.ListarProduto_Movimentacao("P_CONSULTAR_LISTA_PRODUTO", "MOV", Referencia, Descricao, DataInicio, DataFinal, Entrada, Saida, Emprestimo);

        }


        public string TrataNulo(string entrada, string troca)
        {
            if (entrada is DBNull)
            {
                return troca;
            }
            else
            {
                return entrada;
            }

        }
        #endregion
    }
}
