using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SincolPDV.DAL;

namespace SincolPDV.BLL
{
    public class Cliente
    {
        #region atributos
        int codigo;
        string nome;
        string tp_pessoa;
        int status;
        string cpf;
        string cnpj;
        string telefone;
        string endereco;
        string sexo;
        DateTime dtnascimento;
        string email;
        DateTime dtcadastro;        
        DateTime dtatualizacao;
        decimal limiteCrd;
        int limiteDias;
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

        public string Tp_Pessoa
        {
            get { return tp_pessoa; }
            set { tp_pessoa = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
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

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime Dtnascimento
        {
            get { return dtnascimento; }
            set { dtnascimento = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime Dtcadastro
        {
            get { return dtcadastro; }
            set { dtcadastro = value; }
        }

        public DateTime Dtatualizacao
        {
            get { return dtatualizacao; }
            set { dtatualizacao = value; }
        }

        public decimal LimiteCrd
        {
            get { return limiteCrd; }
            set { limiteCrd = value; }
        }

        public int LimiteDias
        {
            get { return limiteDias; }
            set { limiteDias = value; }
        }


        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        #endregion


    #region Metodos
    
        ClienteDAL clie = new ClienteDAL();
        Acesso exe = new Acesso();
        int result;


        public int CadastrarCliente()
        {
            return result = clie.InserirCliente("P_CADASTRAR_CLIENTE", Nome, Tp_Pessoa, Status, Cpf, Cnpj, Telefone, Endereco, Sexo, Dtnascimento, Email, Dtcadastro, Dtatualizacao, LimiteCrd, LimiteDias, Observacao);
        }

        public int AlterarCliente()
        {
            return result = clie.AlterarCliente("P_ALTERAR_CLIENTE", Codigo, Nome, Tp_Pessoa, Status, Cpf, Cnpj, Telefone, Endereco, Sexo, Dtnascimento, Email, Dtcadastro, Dtatualizacao, LimiteCrd, LimiteDias, Observacao);
        }

        public int ExcluirCliente()
        {
            return result = clie.ExcluirCliente("P_DELETAR_CLIENTE", Codigo);
        }

        public void InserirObservacao()
        {
            exe.Executar("update Produto set Clie_Nome =" + Nome + "Clie_Observacao = " + Observacao +
                          "Where Clie_Codigo = " + Codigo);
        }


        public DataTable ListarCliente()
        {
            return clie.ListarCliente("P_CONSULTAR_LISTA_CLIENTE", Codigo, Nome, Cpf, Telefone);

        }


        //public DataTable Consulta_Codigo()
        //{
            //return clie.Consulta_Codigo("P_CONSULTAR_CODIGO", Codigo);

        //}


        public int Consulta()
        {

            ClienteDAL Clie = new ClienteDAL();
            DataTable dt = Clie.ConsultaCliente("P_CONSULTAR_LISTA_CLIENTE_POR_CODIGO", Codigo);

            if (dt.Rows.Count > 0)
            {

                Codigo = Convert.ToInt32(dt.Rows[0]["CLIE_CODIGO"].ToString());
                Nome = dt.Rows[0]["CLIE_NOME"].ToString();
                Tp_Pessoa = dt.Rows[0]["CLIE_TP_PESSOA"].ToString();


                Status = 0;
                if (dt.Rows[0]["CLIE_STATUS"].ToString() != "")
                {
                    Status = Convert.ToInt32(dt.Rows[0]["CLIE_STATUS"].ToString());
                }
                
                Cpf = dt.Rows[0]["CLIE_CPF"].ToString();
                Cnpj = dt.Rows[0]["CLIE_CNPJ"].ToString();
                Telefone = dt.Rows[0]["CLIE_TELEFONE"].ToString();
                //Fabricante = Convert.ToInt32(dt.Rows[0]["FAB_CODIGO"].ToString());
                Endereco = dt.Rows[0]["CLIE_ENDERECO"].ToString();
                Sexo = dt.Rows[0]["CLIE_SEXO"].ToString();

                Dtnascimento = DateTime.Parse("01/01/0001 00:00:00");
                if (dt.Rows[0]["CLIE_DT_NASC"].ToString() != "")
                {
                    Dtnascimento = DateTime.Parse(dt.Rows[0]["CLIE_DT_NASC"].ToString());
                }

                Email = dt.Rows[0]["CLIE_EMAIL"].ToString();

                Dtcadastro = DateTime.Parse("01/01/0001 00:00:00");
                if (dt.Rows[0]["CLIE_DT_CADASTRO"].ToString() != "")
                {
                    Dtcadastro = DateTime.Parse(dt.Rows[0]["CLIE_DT_CADASTRO"].ToString());
                }

                Dtatualizacao = DateTime.Parse("01/01/0001 00:00:00");
                if (dt.Rows[0]["CLIE_DT_ATUALIZACAO"].ToString() != "")
                {
                    Dtatualizacao = DateTime.Parse(dt.Rows[0]["CLIE_DT_ATUALIZACAO"].ToString());
                }

                LimiteCrd = decimal.Parse("00,00");
                if (dt.Rows[0]["CLIE_LIMITE_CREDITO"].ToString() != "")
                {
                    LimiteCrd = decimal.Parse(dt.Rows[0]["CLIE_LIMITE_CREDITO"].ToString());
                }

                
                
                limiteDias = 0;
                if (dt.Rows[0]["CLIE_QTD_DIAS_EMPRESTIMO"].ToString() != "")
                {
                    limiteDias = Convert.ToInt32(dt.Rows[0]["CLIE_QTD_DIAS_EMPRESTIMO"].ToString());
                }

                Observacao = dt.Rows[0]["CLIE_OBSERVACAO"].ToString();

                return 1;
            }
            return 0;
        }

    #endregion


    }
}
