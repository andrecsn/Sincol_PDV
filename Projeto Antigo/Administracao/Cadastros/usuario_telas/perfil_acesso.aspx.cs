using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;



namespace Projeto.Cadastros.usuario_telas
{
    public partial class perfil_acesso : System.Web.UI.Page
    {
        #region Objetos
        Perfil_Acesso pera = new Perfil_Acesso();
        Transacao trn = new Transacao();
        MiniConsulta mn = new MiniConsulta();
        Ferramentas.Uteis ut = new Ferramentas.Uteis();
        Perfil_Transacao pert = new Perfil_Transacao();
         #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                PreencherCombo();
            }

         
        }

        private void PreencherCombo()
        {
            // Preencher a combo Perfil
            pera.Descricao = "";
            listPerfil.DataSource = pera.Consulta();
            listPerfil.DataValueField = "pera_Codigo";
            listPerfil.DataTextField = "pera_Descricao";
            listPerfil.DataBind();


            // Preencher a combo Transacao
            trn.Descricao = "";
            listTransacao.DataSource = trn.Consulta();
            listTransacao.DataValueField = "trn_Codigo";
            listTransacao.DataTextField = "trn_Descricao";
            listTransacao.DataBind();

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            LetAtributos();
            //Metodo para cadastar o Perfil Transações
            pert.CadastrarPerfilTransacao();
            carrega_grid();
            ut.LimpaCampos(this.form1);
            
        }

        // Preenche os objetos da Classe Perfil Transações
        private void LetAtributos()
        {
            pert.Codigo_perfil_acesso = Convert.ToInt32(listPerfil.SelectedValue);
            pert.Codigo_transacao = Convert.ToInt32(listTransacao.SelectedValue);

            pert.Consultar = Convert.ToByte( checkConsultar.Checked);
            pert.Alterar = Convert.ToByte(checkAlterar.Checked);
            pert.Incluir = Convert.ToByte(checkIncluir.Checked);
            pert.Imprimir = Convert.ToByte(checkImprimir.Checked);
            pert.Consultar = Convert.ToByte(checkConsultar.Checked);
            pert.Liberar = Convert.ToByte(checkLiberar.Checked);
            pert.Processar = Convert.ToByte(checkProcessar.Checked);
            pert.Visualizar = Convert.ToByte(checkvisu_totais.Checked);
            pert.Excluir = Convert.ToByte(checkExcluir.Checked);
            
        }


        protected void carrega_grid()
        {
            GridView1.Visible = true;
            GridView1.DataSource = pert.ConsultarPerfilTransacao();
            GridView1.DataBind();
        }

        //Carregar grid 
        protected void checkCarregaGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCarregaGrid.Checked)
            {
                GridView1.Visible = true;
                GridView1.DataSource = pert.ConsultarPerfilTransacao();
                GridView1.DataBind();
            }
            else
            {
                GridView1.Visible = false;
            }
         }


    }
}