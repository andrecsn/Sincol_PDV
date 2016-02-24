using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Operacoes.crm_telas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CRM CRM = new CRM();
        Ferramentas.Uteis ut = new Ferramentas.Uteis();

        public string table_codigo = "CRM_CODIGO";
        public string table_descricao = "CRM_DESCRICAO";
        public string table_select_clie_forn = "CRM_SELECT_CLIE_FORN";
        public string table_clie_forn_nome = "CLIE_FORN_NOME";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                LetAtributos();

                GridView1.DataSource = CRM.ListarCRM();
                GridView1.DataBind();
            }
        }

        public void LetAtributos()
        {
            CRM.Table_Codigo = table_codigo;
            CRM.Table_Descricao = table_descricao;
            CRM.Table_Select_Clie_Forn = table_select_clie_forn;
            CRM.Table_Clie_Forn_Nome = table_clie_forn_nome;
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CRM.Clie_Forn_Nome = "%" + txtNome.Text + "%";
            CRM.Descricao = "%" + txtAssunto.Text + "%";
            CRM.Select_Clie_Forn = "%" + select_clie_forn.SelectedValue + "%";

            GridView1.DataSource = CRM.ListarCRM();
            GridView1.DataBind();
        }

        protected void btnTodos_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = CRM.ListarCRM();
            GridView1.DataBind();
        }

    }
}