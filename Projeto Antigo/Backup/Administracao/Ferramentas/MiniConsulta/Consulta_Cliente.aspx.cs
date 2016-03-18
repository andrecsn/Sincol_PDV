using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Ferramentas.MiniConsulta
{
    public partial class Consulta_Cliente : System.Web.UI.Page
    {
        Cliente cli = new Cliente();
        Ferramentas.Uteis util = new Ferramentas.Uteis();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length >= 3)
            {
                cli.Codigo = 0;
                cli.Nome = "%" + txtNome.Text + "%";
                GridView1.DataSource = cli.ListarCliente();
                GridView1.DataBind();

            }

            else if(("").Equals(txtNome.Text)) { 
                util.ExecutaJS(this, "<script>alert('Digite o nome a ser procurado.');</script>");
               
            
            }
        }
 

    }
}