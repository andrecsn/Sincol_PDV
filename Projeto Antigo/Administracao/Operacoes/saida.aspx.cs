using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Projeto.Operacoes
{
    public partial class saida : System.Web.UI.Page
    {

        Saida Saida = new Saida();
        Ferramentas.Uteis ut = new Ferramentas.Uteis();

        DataRow Linha;
        string parcelas_faltantes;

        protected void Page_Load(object sender, EventArgs e)
        {
                txtDataVencimento.Text = DateTime.Now.ToShortDateString();

            if (IsPostBack == false)
            {
                PreencherCampos();
                ADD_Forma_pagamento();
            }
        }

        private void PreencherCampos()
        {
            txtDataVenda.Text = DateTime.Now.ToShortDateString();

        }


        private void ADD_Forma_pagamento()
        {
            DataTable tbDados;
            DataColumn Coluna;
            DataColumn Coluna2;
            DataColumn Coluna3;
            DataColumn Coluna4;

            Session["contador"] = 0;

            tbDados = new DataTable();
            Coluna = new DataColumn();
            Coluna.DataType = System.Type.GetType("System.String");
            Coluna.ColumnName = "ID";
            tbDados.Columns.Add(Coluna);

            Coluna = new DataColumn();
            Coluna.DataType = System.Type.GetType("System.String");

            Coluna2 = new DataColumn();
            Coluna2.DataType = System.Type.GetType("System.String");

            Coluna3 = new DataColumn();
            Coluna3.DataType = System.Type.GetType("System.String");

            Coluna4 = new DataColumn();
            Coluna4.DataType = System.Type.GetType("System.String");

            Coluna.ColumnName = "Modo de Pagamento";
            Coluna2.ColumnName = "Vencimento";
            Coluna3.ColumnName = "Parcelas";
            Coluna4.ColumnName = "Valor";

            tbDados.Columns.Add(Coluna);
            tbDados.Columns.Add(Coluna2);
            tbDados.Columns.Add(Coluna3);
            tbDados.Columns.Add(Coluna4);

            Session["TabelaDados"] = tbDados;

            GridView2.DataSource = tbDados;
            GridView2.DataBind();
        }


        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            double Valor3 = Convert.ToDouble(txtValor3.Text);
            double Valor2 = Convert.ToDouble(txtValor2.Text);
            int parcela = Convert.ToInt32(listQuantidadeParcelas2.SelectedValue);
            string parcelas = listQuantidadeParcelas2.SelectedValue;

            //Cauculando os valores dos TextBox
            if (listModoPagamento2.SelectedValue == "A Vista" && (Valor3 > 0) && (Valor2 > 0) )
            {
                double resultado = (Valor3 - Valor2);

                if (resultado >= 0){
                
                txtValor3.Text = Convert.ToString(resultado);
                parcelas_faltantes = parcelas;
                incluir_parcelas();
                
                }
            }
            else if (listModoPagamento2.SelectedValue == "Parcelado" && Valor3 > 0 )
            {

                double resultado = (Valor3 / parcela);
                double resultado2 = (Valor3 - (resultado * parcela));
                txtValor3.Text = Convert.ToString(resultado2);

                    for (int i = 1; i <= parcela; i++)
                    {

                        parcelas_faltantes = Convert.ToString(i) + "/" + parcela;

                        int data = ((i) * 30);
                        txtDataVencimento.Text = System.DateTime.Now.AddDays(data).ToString("dd/MM/yyyy");

                        incluir_parcelas();
                    }

            }


        }

        protected void incluir_parcelas()
        {
            DataTable tbDadosSession = new DataTable();
            tbDadosSession = (DataTable)Session["TabelaDados"];

            string modoPagamento = listModoPagamento2.SelectedValue;
            string vencimento = txtDataVencimento.Text;
            string parcelas = parcelas_faltantes;
            string valor2 = txtValor2.Text;

            Linha = tbDadosSession.NewRow();
            Linha["ID"] = Convert.ToInt32(Session["contador"]) + 1;

            Linha["Modo de Pagamento"] = modoPagamento;
            Linha["vencimento"] = vencimento;
            Linha["Parcelas"] = parcelas;
            Linha["Valor"] = valor2;

            tbDadosSession.Rows.Add(Linha);

            Session["TabelaDados"] = tbDadosSession;
            GridView2.DataSource = tbDadosSession;
            GridView2.DataBind();
            Session["contador"] = tbDadosSession.Rows.Count;
        }


        protected void ClienteGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable tbDadosSession = new DataTable();
            tbDadosSession = (DataTable)Session["TabelaDados"];

            double Valor2 = Convert.ToDouble(txtValor2.Text);
            double Valor3 = Convert.ToDouble(txtValor3.Text);
            string valor_retorno = tbDadosSession.Rows[e.RowIndex][4].ToString();

            double valor_retorno2 = Convert.ToDouble(valor_retorno);

            valor_retorno2 = (valor_retorno2 + Valor3);
            txtValor3.Text = Convert.ToString(valor_retorno2);

            tbDadosSession.Rows[e.RowIndex].Delete();

            Session["TabelaDados"] = tbDadosSession;
            GridView2.DataSource = tbDadosSession;
            GridView2.DataBind();
        }

    }
}