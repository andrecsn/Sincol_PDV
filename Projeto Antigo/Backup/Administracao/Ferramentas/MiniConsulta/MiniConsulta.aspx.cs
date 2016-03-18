using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using SincolPDV.BLL;

namespace Administracao
{
    public partial class MnConsulta : System.Web.UI.Page
    {
        MiniConsulta negocio = new MiniConsulta();
        public string Tabela;
        public string ColCodigo;
        public string ColDescricao;

        protected void Page_Load(object sender, EventArgs e)
        {

            txtTabela.Text = Request.QueryString["Tabela"].ToString();
            txtColCod.Text = Request.QueryString["ColCod"].ToString();
            txtColDesc.Text = Request.QueryString["ColDesc"].ToString();

            LetAtributos();

            if (IsPostBack == false)
            {
                negocio.VerificaBD();
                Listar();
            }
           
        }


        private void Listar()
        {
            negocio.VerificaBD();

            GridView1.DataSource = negocio.Lista();
            GridView1.DataBind();
        }


        private void Limpar()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            negocio.Codigo = 0;
            negocio.Descricao = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {           
            
            negocio.Descricao = txtDescricao.Text.Replace("'", "''");
            if (txtCodigo.Text == "")
            {
                negocio.Insere();
            }
            else
            {
                negocio.Codigo = Int32.Parse(txtCodigo.Text);
                negocio.Altera();
            }
            Limpar();
            Listar();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            negocio.Codigo = Convert.ToInt32(txtCodigo.Text);
            negocio.Exclui();
            Limpar();
            Listar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_Command(object sender, CommandEventArgs e)
        {

            txtCodigo.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["CODIGO"].ToString();
            txtDescricao.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["DESCRICAO"].ToString();
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        public void LetAtributos()
        {
            negocio.Tabela = txtTabela.Text;  //"FABRICANTES";
            negocio.ColunaCod = txtColCod.Text;// "FAB_CODIGO";
            negocio.ColunaDesc = txtColDesc.Text;  //"FAB_DESCRICAO";
                       
        }


      
    }
}
