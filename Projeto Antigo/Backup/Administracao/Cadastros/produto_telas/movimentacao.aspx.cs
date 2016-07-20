using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Cadastros.produto_telas
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Produto prod = new Produto();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            prod.Referencia = txtReferencia.Text;
            prod.Descricao = txtDescricao.Text;
            prod.DataInicio = txtDtInicio.Text;
            prod.DataFinal = txtDtFinal.Text;

            if (checkEntrada.Checked)
            {
                prod.Entrada = "S";
            }

            if (checkSaida.Checked)
            {
                prod.Saida = "S";
            }

            if (checkEmprestimo.Checked)
            {
                prod.Emprestimo = "S";
            }

            GridView1.DataSource = prod.ListarProduto_Movimentacao();
            GridView1.DataBind();

        }
    }
}