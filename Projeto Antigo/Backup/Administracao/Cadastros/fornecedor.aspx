<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fornecedor.aspx.cs" Inherits="Projeto.Cadastros.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cadastro de Fornecedor</title>

    <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../css/estilos_formulario/css/estilo.css" type="text/css" />

<!-----------------------------------------Scripts de Validação----------------------------------------->
<script type="text/javascript" src="../js/validacao/jquery-1.7.2.min.js"></script>
<script type="text/javascript" src="../js/validacao/jquery.maskedinput-1.3.min.js"></script>
<script type="text/javascript" src="../js/Sincol.js"></script>
<!-----------------------------------------FIM Scripts de Validação------------------------------------->
	
	<script type="text/javascript" src="../css/estilos_formulario/js/jquery.js" ></script>
	<script type="text/javascript" src="../css/estilos_formulario/jquery.jqtransform.js" ></script>
    <script type="text/javascript" src="../Ferramentas/Uteis.js" ></script>
	<script language="javascript">
	    $(function () {
	        $('form').jqTransform({ imgPath: 'jqtransformplugin/img/' });
	    });
	</script>
<!--FIM Estilos de Formulário-->

</head>

<body>

     <form id="form1" runat="server">
       <div class="corpo">
         <fieldset>
   <legend class="field">Cadastro de Fornecedor
   
</legend><table width="100%" border="0" cellpadding="0" cellspacing="5" 
                 style="height: 356px">
                     <tr>
                       <td width="239" height="21">Código:</td>
                       <td colspan="2">Nome:</td>
                       <td>
                           <asp:CheckBox ID="checkStatus" runat="server" Text="Ativo" />
                         </td>
                     </tr>
                     <tr>
                       <td>
                           <asp:TextBox ID="txtCodigo" Width="117px" runat="server" Columns="10" 
                               ontextchanged="txtCodigo_TextChanged" AutoPostBack="True" placeholder="001"></asp:TextBox>
                         </td>
                       <td colspan="3">
                           <asp:TextBox ID="txtNome" runat="server" Columns="55" placeholder="Digite o nome completo"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td>Pessoa-Tipo:</td>
                       <td width="326">CPF:</td>
                       <td colspan="2">CNPJ:</td>
                     </tr>
                     <tr>
                       <td>
                           <asp:DropDownList ID="dropPessoa" runat="server">
                               <asp:ListItem Value="F">Física</asp:ListItem>
                               <asp:ListItem Value="J">Juridica</asp:ListItem>
                           </asp:DropDownList>
                         </td>
                       <td>
                           <asp:TextBox ID="txtCPF" class="cpf" runat="server" Columns="15"></asp:TextBox>
                         </td>
                       <td colspan="2">
                           <asp:TextBox ID="txtCNPJ" class="cnpj" runat="server" Columns="15"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td>Telefone:</td>
                       <td>Endereço:</td>
                       <td width="134">&nbsp;</td>
                       <td width="623">&nbsp;</td>
                     </tr>
                     <tr>
                       <td>
                           <asp:TextBox ID="txtTelefone" class="fone" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="3">
                           <asp:TextBox ID="txtEndereco" runat="server" Columns="55" placeholder="Digite o endereço completo"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td>Email:</td>
                       <td>&nbsp;</td>
                       <td colspan="2">Dados Bancários:</td>
                     </tr>
                     <tr>
                       <td colspan="2">
                           <asp:TextBox ID="txtEmail" runat="server" Columns="28" placeholder="nome@seuemail.com"></asp:TextBox>
                         </td>
                       <td colspan="2">
                           <asp:TextBox ID="txtDadosBancarios" runat="server" Columns="10"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td colspan="4">Observações:</td>
                     </tr>
                     <tr>
                       <td colspan="4">
                           <asp:TextBox ID="txtObservacao" runat="server" Height="91px" 
                               TextMode="MultiLine" Width="690px"></asp:TextBox>
                         </td>
                     </tr>
                     </table>
         </fieldset>
         
         </br>
         
         <fieldset>
           <legend class="field">Botões de Ação</legend>
           <table width="100%" border="0" cellpadding="0" cellspacing="5">
             <tr>
               <td>
                   <asp:Button class='button_form' ID="btnGravar" runat="server" Text="Gravar" OnClick = "btnGravar_Click" OnClientClick="return validarFornecedor()" />
                   <asp:Button class='button_form' ID="btnAlterar" runat="server" Text="Alterar" onclick="btnAlterar_Click" OnClientClick="return validarFornecedor()" />
                   <asp:Button class='button_form' ID="btnExcluir" runat="server" Text="Excluir" onclick="btnExcluir_Click" OnClientClick="return confirm('Tem certeza disso?')" />
                   <asp:Button class='button_form' ID="btnLimpar" runat="server"  Text="Limpar" onclick="btnLimpar_Click" />
                 </td>
               <td width="75">
                   <asp:Button class='button_form' ID="btnHelp" runat="server" Text="Help"  onclick="btnAjuda_Click" />
                 </td>
             </tr>
           </table>
         </fieldset>
       </div>
     </form>

</body>
</html>

