using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Cadastros.produto_telas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Produto prod = new Produto();
        Fabricante fab = new Fabricante();


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
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            prod.Referencia = txtReferencia.Text;
            prod.Descricao = txtDescricao.Text;
            prod.Origem = listOrigem.SelectedValue;
            prod.Fabricante = Convert.ToInt32(listFabricante.SelectedValue);
            prod.Modelo = txtModelo.Text;
            prod.Marca = txtMarca.Text;

           GridView1.DataSource = prod.ListarProduto();
           GridView1.DataBind();

        }
    }
}