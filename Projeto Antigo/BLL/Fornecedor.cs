using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;

namespace SincolPDV.BLL
{
    public class Fornecedor
    {
        #region atributos
        int codigo;
        string nome;
        int status;
        string pessoa;
        string cpf;
        string cnpj;
        string telefone;
        string endereco;
        string dadosBancarios;
        string email;
        string observacao;
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

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string DadosBancarios
        {
            get { return dadosBancarios; }
            set { dadosBancarios = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        #endregion


        #region Metodos

        FornecedorDAL forn = new FornecedorDAL();
        Acesso exe = new Acesso();
        int result;


        public int CadastrarFornecedor()
        {
            return result = forn.InserirFornecedor("P_CADASTRAR_FORNECEDOR", Nome, Status, Pessoa, Cpf, Cnpj, Telefone, Endereco, Email, DadosBancarios, Observacao);
        }

        public int AlterarFornecedor()
        {
            return result = forn.AlterarFornecedor("P_ALTERAR_FORNECEDOR", Codigo, Nome, Status, Pessoa, Cpf, Cnpj, Telefone, Endereco, Email, DadosBancarios, Observacao);
        }

        public int ExcluirFornecedor()
        {
            return result = forn.ExcluirForncedor("P_DELETAR_FORNECEDOR", Codigo);
        }

        public void InserirObservacao()
        {
            exe.Executar("update Fornecedor set Forn_Nome =" + Nome + "Forn_Observacao = " + Observacao +
                          "Where Forn_Codigo = " + Codigo);
        }


        public DataTable ListarFornecedor()
        {
            return forn.ListarFornecedor("P_CONSULTAR_LISTA_FORNECEDOR", Codigo, Nome, Cpf, Telefone);

        }


        public int Consulta()
        {

            FornecedorDAL Forn = new FornecedorDAL();
            DataTable dt = Forn.ConsultaFornecedor("P_CONSULTAR_LISTA_FORNECEDOR_POR_CODIGO", Codigo);

            if (dt.Rows.Count > 0)
            {

                Codigo = Convert.ToInt32(dt.Rows[0]["FORN_CODIGO"].ToString());
                Nome = dt.Rows[0]["FORN_NOME"].ToString();
                Pessoa = dt.Rows[0]["FORN_TP_PESSOA"].ToString();


                Status = 0;
                if (dt.Rows[0]["FORN_STATUS"].ToString() != "")
                {
                    Status = Convert.ToInt32(dt.Rows[0]["FORN_STATUS"].ToString());
                }

                Cpf = dt.Rows[0]["FORN_CPF"].ToString();
                Cnpj = dt.Rows[0]["FORN_CNPJ"].ToString();
                Telefone = dt.Rows[0]["FORN_TELEFONE"].ToString();
                Endereco = dt.Rows[0]["FORN_ENDERECO"].ToString();
                Email = dt.Rows[0]["FORN_EMAIL"].ToString();
                DadosBancarios = dt.Rows[0]["FORN_DADOS_BANCARIOS"].ToString();
                Observacao = dt.Rows[0]["FORN_OBSERVACAO"].ToString();

                return 1;
            }
            return 0;
        }

        #endregion
    }
}
