using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;


namespace Projeto.Cadastros
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Fabricante fab = new Fabricante();
        Produto produto = new Produto();
        MiniConsulta mn = new MiniConsulta();
        Ferramentas.Uteis ut = new Ferramentas.Uteis();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                PreencherCombo();
            }
        }

        private void PreencherCombo()
        {
            // Preencher a combo Fabricante
            fab.Descricao = "";
            listFabricante.DataSource = fab.Consulta();
            listFabricante.DataValueField = "Fab_Codigo";
            listFabricante.DataTextField = "Fab_Descricao";
            listFabricante.DataBind();

            //Preencher a combo Unidade de Entrada e Unidade de Saida

            mn.Tabela = "T_Armazenamento";
            mn.ColunaCod = "Arm_Codigo";
            mn.ColunaDesc = "Arm_Estoque";
            //Unidade de Entrada
            listUniEntrada.DataSource = mn.Lista();
            listUniEntrada.DataValueField = "Codigo"; // "Arm_Codigo";
            listUniEntrada.DataTextField = "Descricao"; //  "Arm_Estoque";
            listUniEntrada.DataBind();
            // Unidade de Saida
            listUniSaida.DataSource = mn.Lista();
            listUniSaida.DataValueField = "Codigo"; // "Arm_Codigo";
            listUniSaida.DataTextField = "Descricao"; //"Arm_Estoque";
            listUniSaida.DataBind();
            
        }


        protected void btnGravar_Click(object sender, EventArgs e)
        {
                PreencherObjetos();
                produto.CadastrarProduto();
        }


        protected void btnAlterar_Click(object sender, EventArgs e)
        {
                PreencherObjetos();
                produto.AlterarProduto();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            PreencherObjetos();
            produto.ExcluirProduto();
        }


        private void PreencherObjetos()
        {
            string Status;

            if (chkAtivo.Checked)
            {
                Status = "S";
            }
            else
            {
                Status = "N";
            }

            if (txtCodigo.Text != "")
            {
                produto.Codigo = Convert.ToInt32(txtCodigo.Text);
            }
            produto.Referencia = txtReferencia.Text;
            produto.Descricao = txtDescricao.Text;
            produto.EstMaximo = Convert.ToInt32(txtEstoMaximo.Text);
            produto.EstMinimo = Convert.ToInt32(txtEstoMinimo.Text);
            produto.Fabricante = Convert.ToInt32(listFabricante.SelectedValue);
            produto.Fator = Convert.ToInt32(txtFator.Text);
            produto.Marca = txtMarca.Text;
            produto.Modelo = txtModelo.Text;
            produto.Origem = listOrigem.Text;
            produto.Peso = txtPeso.Text;
            produto.PrecoUnitario = decimal.Parse(txtPrecoUni.Text);
            produto.Status = Status;
            produto.Tpsaida = 2; //Convert.ToInt32(listTpSaida.Text);
            produto.UnEntrada = listUniEntrada.Text;
            produto.UnSaida = listUniSaida.Text;
            produto.Observacao = txtObservacao.Text;
        }


        protected void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            preencher_campos();
        }



        protected void preencher_campos()
        {
            produto.Referencia = txtReferencia.Text;
            int retorno = produto.Consulta();
            ut.LimpaCampos(this.form1);
            txtReferencia.Text = produto.Referencia;
            if (retorno > 0)
            {
                txtDescricao.Text = produto.Descricao;
                txtCodigo.Text = produto.Codigo.ToString();
                txtEstoMaximo.Text = produto.EstMaximo.ToString();
                txtEstoMinimo.Text = produto.EstMinimo.ToString();
                listFabricante.Text = produto.Fabricante.ToString();
                txtFator.Text = produto.Fator.ToString();
                txtMarca.Text = produto.Marca;
                txtModelo.Text = produto.Modelo;
                listOrigem.Text = produto.Origem;
                txtPeso.Text = produto.Peso.ToString();
                txtPrecoUni.Text = produto.PrecoUnitario.ToString();
                txtReferencia.Text = produto.Referencia.ToString();
                listUniEntrada.Text = produto.UnEntrada;
                listUniSaida.Text = produto.UnSaida;
                txtObservacao.Text = produto.Observacao;


                if (produto.Status == "S")
                {
                    chkAtivo.Checked = true;
                }
                else
                {
                    chkAtivo.Checked = false;
                }

                btnGravar.Visible = false;
            }
            else
            {
                btnGravar.Visible = true;
            }

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            ut.LimpaCampos(this.form1);
        }

        protected void btnAjuda_Click(object sender, EventArgs e)
        {

            ut.ExecutaJS(this, "<script>Ajuda('../Ferramentas/HelpDinamico/HelpDinamico.aspx?Hlp=" + this + "');</script>");
        }
    }
}