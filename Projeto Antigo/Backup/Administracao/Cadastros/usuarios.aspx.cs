using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Cadastros
{
    public partial class usuarios : System.Web.UI.Page
    {

        Perfil_Acesso pera = new Perfil_Acesso();
        Usuario usuario = new Usuario();
        Ferramentas.Uteis ut = new Ferramentas.Uteis();

        public string Tabela;
        public string ColCodigo;
        public string ColNome;
        public string ColLogin;
        public string ColSenha;

        protected void Page_Load(object sender, EventArgs e)
        {

            txtTabela.Text = "USUARIO";
            txtColCod.Text = "USU_CODIGO";
            txtColNome.Text = "USU_NOME";
            txtColLogin.Text = "USU_LOGIN";
            txtColSenha.Text = "USU_SENHA";
            txtColPerfil.Text = "PERA_CODIGO";
            txtColAtivo.Text = "USU_STATUS";

            LetAtributos();

            if (IsPostBack == false)
            {
                PreencherCombo();
                Listar();
            }
        }


        private void PreencherCombo()
        {
            // Preencher a combo Perfil de Acesso
            pera.Descricao = "";
            listPerfilAcesso.DataSource = pera.Consulta();
            listPerfilAcesso.DataValueField = "PERA_Codigo";
            listPerfilAcesso.DataTextField = "PERA_Descricao";
            listPerfilAcesso.DataBind();
        }


        private void Listar()
        {
            GridView1.DataSource = usuario.Lista();
            GridView1.DataBind();
        }


        public void LetAtributos()
        {
            usuario.Tabela = txtTabela.Text;
            usuario.ColunaCod = txtColCod.Text;
            usuario.ColunaNome = txtColNome.Text;
            usuario.ColunaLogin = txtColLogin.Text;
            usuario.ColunaSenha = txtColSenha.Text;
            usuario.ColunaPerfil = txtColPerfil.Text;
            usuario.ColunaAtivo = txtColAtivo.Text;

        }


        protected void GridView1_Command(object sender, CommandEventArgs e)
        {
            txtCodigo.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["CODIGO"].ToString();
            txtNome.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["NOME"].ToString();
            
            txtLogin.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["LOGIN"].ToString();
            txtSenha.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["SENHA"].ToString();
            listPerfilAcesso.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["PERFIL"].ToString();
            checkAtivo2.Text = GridView1.DataKeys[Int32.Parse(e.CommandArgument.ToString())]["ATIVO"].ToString();

            if (checkAtivo2.Text == "1")
            {
                checkAtivo.Checked = true;
            }
            else
            {
                checkAtivo.Checked = false;
            }

            btnIncluir.Visible = false;
            btnLimpar.Visible = true;
        }


        private void PreencherObjetos()
        {
            int Status;

            if (checkAtivo.Checked)
            {
                Status = 1;
            }
            else
            {
                Status = 0;
            }

            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "0";
            }

            usuario.Codigo = Convert.ToInt32(txtCodigo.Text);
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Status = Status;
            usuario.Perfil_Acesso = Convert.ToInt32(listPerfilAcesso.Text);
        }


        protected void btnGravar_Click(object sender, EventArgs e)
        {
            int validaCampos = CriticaCampos();

            if (validaCampos == 0)
            {
                PreencherObjetos();

                usuario.CadastrarUsuario();
            }
            Listar();
        }


        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            int validaCampos = CriticaCampos();

            if (validaCampos == 0)
            {
                PreencherObjetos();

                usuario.AlterarUsuario();

                ut.LimpaCampos(this.form1);
            }
            Listar();
        }


        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int validaCampos = CriticaCampos();

            if (validaCampos == 0)
            {
                PreencherObjetos();

                usuario.ExcluirUsuario();
            }

            Listar();

        }


        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            ut.LimpaCampos(this.form1);

            btnIncluir.Visible = true;
            btnLimpar.Visible = false;
        }


        protected int CriticaCampos()
        {


            if (txtNome.Text == "")
            {
                ut.ExecutaJS(this, "<script>MsgBox('O Campo Nome deve esta preenchido');</script>");
                return 1;

            }
            if (txtLogin.Text == "")
            {
                ut.ExecutaJS(this, "<script>MsgBox('O Campo Login deve esta Preenchido');</script>");
                return 1;

            }
            if (txtSenha.Text == "")
            {
                ut.ExecutaJS(this, "<script>MsgBox('O Campo Senha deve esta Preenchido');</script>");
                return 1;

            }
            else
            {
                return 0;
            }

        }


        protected void preencher_campos()
        {
            usuario.Codigo = Convert.ToInt32(txtCodigo.Text);
            int retorno = usuario.Consulta();
            ut.LimpaCampos(this.form1);
            txtCodigo.Text = usuario.Codigo.ToString();
            if (retorno > 0)
            {
                txtCodigo.Text = usuario.Codigo.ToString();
                txtLogin.Text = usuario.Login;
                txtNome.Text = usuario.Nome;
                txtSenha.Text = usuario.Senha;
                
                if (Convert.ToInt32(usuario.Perfil_Acesso.ToString()) > 0)
                {
                    listPerfilAcesso.SelectedValue = usuario.Perfil_Acesso.ToString();
                }


                if (usuario.Status == 1)
                {
                    checkAtivo.Checked = true;
                }
                else
                {
                    checkAtivo.Checked = false;
                }
            }

        }
     }
}