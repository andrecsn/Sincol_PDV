<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="Projeto.Cadastros.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cadastro de Cliente</title>

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
	    function listDias_emprestimo_onclick() {

	    }

    </script>
<!--FIM Estilos de Formulário-->

</head>

<body>

   

     <form id="form1" runat="server">

       <div class="corpo">
         <fieldset>
   <legend class="field">Cadastro de Cliente</legend>
   



   <table border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="27" class="style2">Código:</td>
                       <td colspan="2">Nome:</td>
                       <td>
                           <asp:CheckBox ID="checkStatus" runat="server" Text="Ativo" />
                         </td>
                     </tr>
                     <tr>
                       <td height="24" class="style2">
                           <asp:TextBox ID="txtCodigo" runat="server" Columns="10"
                           ontextchanged="txtCodigo_TextChanged" AutoPostBack="True" placeholder="001"></asp:TextBox>
                         </td>
                       <td colspan="3">
                         <asp:TextBox ID="txtNome" runat="server" Columns="55" placeholder="Digite o nome completo"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="26" class="style2">Pessoa-Tipo:</td>
                       <td valign="top">CPF:</td>
                       <td valign="top">CNPJ:</td>
                       <td valign="top">&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="27">
                           <asp:DropDownList ID="dropPessoa" runat="server" Width="77px">
                               <asp:ListItem Value="F">Física</asp:ListItem>
                               <asp:ListItem Value="J">Juridica</asp:ListItem>
                           </asp:DropDownList>
                         </td>
                       <td valign="top"><asp:TextBox ID="txtCPF" runat="server" class="cpf" Columns="11"></asp:TextBox></td>
                       <td valign="top"><asp:TextBox ID="txtCNPJ" runat="server" class="cnpj" Columns="15"></asp:TextBox></td>
                       <td valign="top"></td>
                     </tr>
                     <tr>
                       <td height="23">Telefone:</td>
                       <td>Endereço:</td>
                       <td width="187">&nbsp;</td>
                       <td width="226">&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="24">
                           <asp:TextBox ID="txtTelefone" class="fone" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="3">
                         <asp:TextBox ID="txtEndereco" runat="server" Columns="55" placeholder="Digite o endereço completo"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="20">Sexo:</td>
                       <td>Dt. Nascimento:</td>
                       <td>Email:</td>
                       <td>&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="25">
                           <asp:DropDownList ID="dropSexo" runat="server" Width="77px">
                               <asp:ListItem Value="M">Masculino</asp:ListItem>
                               <asp:ListItem Value="F">Feminino</asp:ListItem>
                           </asp:DropDownList>
                         </td>
                       <td>
                         <asp:TextBox ID="txtNascimento" class="data" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="2">
                           <asp:TextBox ID="txtEmail" runat="server" Columns="30" placeholder="nome@seuemail.com"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="25">Dt. Cadastro:</td>
                       <td>Dt. Atualização:</td>
                       <td>Limite de Crédito:</td>
                       <td>Dias de Emprestimo:</td>
                     </tr>
                     <tr>
                       <td height="20">
                           <asp:TextBox ID="txtdt_cadastro" class="data" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td>
                         <asp:TextBox ID="txtdt_atualizacao" class="data" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td>
                           <asp:TextBox ID="txtLimiteCredito" runat="server" Columns="10" placeholder="0,00"></asp:TextBox>
                         </td>
                       <td>
                           <asp:DropDownList ID="dropDias_Emprestimo" runat="server" Width="80px">
                               <asp:ListItem Text="1 Dia" Value="1"></asp:ListItem>
                               <asp:ListItem Text="2 Dias" Value="2"></asp:ListItem>
                               <asp:ListItem Text="3 Dias" Value="3"></asp:ListItem>
                               <asp:ListItem Text="4 Dias" Value="4"></asp:ListItem>
                               <asp:ListItem Text="5 Dias" Value="5"></asp:ListItem>
                               <asp:ListItem Text="6 Dias" Value="6"></asp:ListItem>
                               <asp:ListItem Text="7 Dias" Value="7"></asp:ListItem>
                               <asp:ListItem Text="8 Dias" Value="8"></asp:ListItem>
                               <asp:ListItem Text="9 Dias" Value="9"></asp:ListItem>
                               <asp:ListItem Text="10 Dias" Value="10"></asp:ListItem>
                               <asp:ListItem Text="11 Dias" Value="11"></asp:ListItem>
                               <asp:ListItem Text="12 Dias" Value="12"></asp:ListItem>
                               <asp:ListItem Text="13 Dias" Value="13"></asp:ListItem>
                               <asp:ListItem Text="14 Dias" Value="14"></asp:ListItem>
                               <asp:ListItem Text="15 Dias" Value="15"></asp:ListItem>
                               <asp:ListItem Text="16 Dias" Value="16"></asp:ListItem>
                               <asp:ListItem Text="17 Dias" Value="17"></asp:ListItem>
                               <asp:ListItem Text="18 Dias" Value="18"></asp:ListItem>
                               <asp:ListItem Text="19 Dias" Value="19"></asp:ListItem>
                               <asp:ListItem Text="20 Dias" Value="20"></asp:ListItem>
                           </asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                       <td colspan="4">Observações:</td>
                     </tr>
                     <tr>
                       <td colspan="4">
                           <asp:TextBox ID="txtObservacao" runat="server" Height="106px" TextMode="MultiLine" 
                               Width="686px"></asp:TextBox>
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
                   <asp:Button class='button_form' ID="btnGravar" runat="server" Text="Gravar" onclick="btnGravar_Click" OnClientClick="return validarCliente()" />                   
                   <asp:Button class='button_form' ID="btnAlterar" runat="server" Text="Alterar" onclick="btnAlterar_Click" OnClientClick="return validarCliente()" />                   
                   <asp:Button class='button_form' ID="btnExcluir" runat="server" Text="Excluir" onclick="btnExcluir_Click" OnClientClick="return confirm('Tem certeza disso?')" />                   
                   <asp:Button class='button_form' ID="btnLimpar" runat="server"  Text="Limpar" onclick="btnLimpar_Click" />
               </td>
               <td width="60">
                   <asp:Button class='button_form' ID="btnHelp" runat="server" Text="Help" onclick="btnAjuda_Click" />
                 </td>
             </tr>
           </table>

           

         </fieldset>
       </div>
     </form>

</body>
</html>

