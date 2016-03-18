using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        Fabricante fab = new Fabricante();
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

            //Preencher a combo Unidade de Entrada e Unidade de Saida

            mn.Tabela = "T_Armazenamento";
            mn.ColunaCod = "Arm_Codigo";
            mn.ColunaDesc = "Arm_Estoque";

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Server.Transfer("Logout.aspx");
        }
    }
}