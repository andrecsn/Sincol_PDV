using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;


namespace Projeto.Operacoes
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Ferramentas.Uteis ut = new Ferramentas.Uteis();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAjuda_Click(object sender, EventArgs e)
        {

            ut.ExecutaJS(this, "<script>Ajuda('../Ferramentas/HelpDinamico/HelpDinamico.aspx?Hlp=" + this + "');</script>");
        }
    }
}