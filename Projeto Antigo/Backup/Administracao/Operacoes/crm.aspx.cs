using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Operacoes
{
    public partial class crm : System.Web.UI.Page
    {

        CRM CRM = new CRM();
        Ferramentas.Uteis ut = new Ferramentas.Uteis();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                datas();
                codigo_CRM();
            }
        }


        protected void codigo_CRM()
        {
            CRM.CódigoCRM();
            txtReferencia.Text = Convert.ToString(CRM.Codigo);
        }

        protected void datas()
        {
            txtData.Text = DateTime.Now.ToShortDateString();
            txtDtResposta.Text= System.DateTime.Now.AddDays(9).ToString("dd/MM/yyyy");
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            int validaCampos = CriticaCampos();

            if (validaCampos == 0)
            {
                PreencherObjetos();

                CRM.CadastrarCRM();

                ut.LimpaCampos(this.form1);
                datas();
                codigo_CRM();

            }

        }


        private void PreencherObjetos()
        {

            CRM.Descricao = txtDescricao.Text;
            CRM.Select_Clie_Forn = select_cli_forn.Text;
            CRM.Clie_Forn_Codigo = Convert.ToInt32(txtCli_Forn_ID.Text);
            CRM.Clie_Forn_Nome = txtCli_Forn_Nome.Text;
            CRM.Assunto = txtAssunto.Text;
            CRM.Texto = txtTexto.Text;
            CRM.Status_resposta = status_resposta.Text;
            CRM.Data_resposta = txtDtResposta.Text;
            CRM.Resposta = txtResposta.Text;
            CRM.Data = txtData.Text;
        }


        protected int CriticaCampos()
        {


            if (txtReferencia.Text == "")
            {
                ut.ExecutaJS(this, "<script>MsgBox('O Campo Código deve esta preenchido');</script>");
                return 1;
            }

            if (txtDescricao.Text == "")
            {
                ut.ExecutaJS(this, "<script>MsgBox('O Campo Descrição deve esta Preenchido');</script>");
                return 1;
            }

            else
            {
                return 0;
            }

        }

    }
}