using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Cadastros
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Fornecedor fornecedor = new Fornecedor();
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

        }

        protected void btnAjuda_Click(object sender, EventArgs e)
        {

            ut.ExecutaJS(this, "<script>Ajuda('../Ferramentas/HelpDinamico/HelpDinamico.aspx?Hlp=" + this + "');</script>");
        }


        protected void btnGravar_Click(object sender, EventArgs e)
        {
            PreencherObjetos();
            fornecedor.CadastrarFornecedor();

            ut.LimpaCampos(this.form1);
        }


        protected void btnAlterar_Click(object sender, EventArgs e)
        {
                PreencherObjetos();
                fornecedor.AlterarFornecedor();
        }


        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                fornecedor.Codigo = Convert.ToInt32(txtCodigo.Text);
                fornecedor.ExcluirFornecedor();

                ut.LimpaCampos(this.form1);
            }
        }


        private void PreencherObjetos()
        {
            int Status;

            if (checkStatus.Checked)
            {
                Status = 1;
            }
            else
            {
                Status = 0;
            }

            fornecedor.Codigo = Convert.ToInt32(txtCodigo.Text);
            fornecedor.Nome = txtNome.Text;
            fornecedor.Status = Status;
            fornecedor.Pessoa = dropPessoa.SelectedValue;
            fornecedor.Cpf = txtCPF.Text;
            fornecedor.Cnpj = txtCNPJ.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.DadosBancarios = txtDadosBancarios.Text;
            fornecedor.Observacao = txtObservacao.Text;

        }


        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            preencher_campos();
        }

        protected void preencher_campos()
        {
            fornecedor.Codigo = Convert.ToInt32(txtCodigo.Text);
            int retorno = fornecedor.Consulta();
            ut.LimpaCampos(this.form1);
            txtCodigo.Text = fornecedor.Codigo.ToString();
            if (retorno > 0)
            {
                txtCodigo.Text = fornecedor.Codigo.ToString();
                txtNome.Text = fornecedor.Nome;
                dropPessoa.Text = fornecedor.Pessoa.ToString();
                txtCPF.Text = fornecedor.Cpf;
                txtCNPJ.Text = fornecedor.Cnpj;
                txtTelefone.Text = fornecedor.Telefone.ToString();
                txtEndereco.Text = fornecedor.Endereco;
                txtEmail.Text = fornecedor.Email;
                txtDadosBancarios.Text = fornecedor.DadosBancarios;
                txtObservacao.Text = fornecedor.Observacao;


                if (fornecedor.Status == 1)
                {
                    checkStatus.Checked = true;
                }
                else
                {
                    checkStatus.Checked = false;
                }

                btnGravar.Visible = false;
            }
            else
            {
                btnGravar.Visible = true;
            }

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            ut.LimpaCampos(this.form1);

            btnGravar.Visible = true;
        }
        /*
        protected void btnAjuda_Click(object sender, EventArgs e)
        {

            ut.ExecutaJS(this, "<script>Ajuda('../Ferramentas/HelpDinamico/HelpDinamico.aspx?Hlp=" + this + "');</script>");
        }*/
    }
}