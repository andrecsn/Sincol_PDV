using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SincolPDV.BLL;

namespace Projeto.Cadastros
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Cliente cliente = new Cliente();
        MiniConsulta mn = new MiniConsulta();
        Ferramentas.Uteis ut = new Ferramentas.Uteis();


        protected void btnGravar_Click(object sender, EventArgs e)
        {
            PreencherObjetos();
            cliente.CadastrarCliente();

            ut.LimpaCampos(this.form1);

        }


        protected void btnAlterar_Click(object sender, EventArgs e)
        {
                PreencherObjetos();
                cliente.AlterarCliente();
        }


        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
                cliente.ExcluirCliente();

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

            cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
            cliente.Nome = txtNome.Text;
            cliente.Status = Status;
            cliente.Tp_Pessoa = dropPessoa.SelectedValue;
            cliente.Cpf = txtCPF.Text;
            cliente.Cnpj = txtCNPJ.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Sexo = dropSexo.SelectedValue;
            cliente.Dtnascimento = DateTime.Parse(txtNascimento.Text);
            cliente.Email = txtEmail.Text;
            cliente.Dtcadastro = DateTime.Parse (txtdt_cadastro.Text);
            cliente.Dtatualizacao = DateTime.Parse (txtdt_atualizacao.Text);
            cliente.LimiteCrd = decimal.Parse (txtLimiteCredito.Text);
            cliente.LimiteDias = Convert.ToInt32(dropDias_Emprestimo.SelectedValue);
            cliente.Observacao = txtObservacao.Text;
        }
        
        
        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            preencher_campos();
        }

        protected void preencher_campos()
        {
            cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
            int retorno = cliente.Consulta();
            ut.LimpaCampos(this.form1);
            txtCodigo.Text = cliente.Codigo.ToString();
            if (retorno > 0)
            {
                txtCodigo.Text = cliente.Codigo.ToString();
                txtNome.Text = cliente.Nome;
                dropPessoa.Text = cliente.Tp_Pessoa.ToString();
                txtCPF.Text = cliente.Cpf;
                txtCNPJ.Text = cliente.Cnpj;
                txtTelefone.Text = cliente.Telefone.ToString();
                txtEndereco.Text = cliente.Endereco;
                dropSexo.Text = cliente.Sexo;
                txtNascimento.Text = cliente.Dtnascimento.ToString();
                txtEmail.Text = cliente.Email;
                txtdt_cadastro.Text = cliente.Dtcadastro.ToString();
                txtdt_atualizacao.Text = cliente.Dtatualizacao.ToString();
                txtLimiteCredito.Text = cliente.LimiteCrd.ToString();
                dropDias_Emprestimo.Text = cliente.LimiteDias.ToString();
                txtObservacao.Text = cliente.Observacao;


                if (cliente.Status == 1)
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
        
        protected void btnAjuda_Click(object sender, EventArgs e)
        {

            ut.ExecutaJS(this, "<script>Ajuda('../Ferramentas/HelpDinamico/HelpDinamico.aspx?Hlp=" + this + "');</script>");
        }


    }
}