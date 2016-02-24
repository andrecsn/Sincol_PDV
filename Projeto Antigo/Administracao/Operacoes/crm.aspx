<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crm.aspx.cs" Inherits="Projeto.Operacoes.crm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
    <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../css/estilos_formulario/css/estilo.css" type="text/css" />
    <script type="text/javascript" src="../css/estilos_formulario/js/jquery.js" ></script>
	<script type="text/javascript" src="../css/estilos_formulario/jquery.jqtransform.js" ></script>

    <script type="text/javascript" src="../Ferramentas/Uteis.js" ></script>

	<script language="javascript">
	    $(function () {
	        $('form').jqTransform({ imgPath: 'jqtransformplugin/img/' });
	    });
    </script>
    <!--FIM Estilos de Formulário-->

<script language="javascript">
    function Popup(tela) {

        var aForm;
        aForm = form1.elements;
        var myObject = new Object();

        retorno = window.showModalDialog(tela, myObject, 'dialogHeight:350px; dialogWidth:450px; dialogLeft:500px;');

    }

    function MsgBox(mensagem) {
        alert(mensagem);
    }
</script>


<style type="text/css">
.separacao {
	height: 10px;
	width: 100%;
	border-bottom-width: thin;
	border-bottom-style: dashed;
	border-bottom-color: #CCC;
}
</style>

</head>
<body>

     <form id="form1" runat="server" method="get">
       <div class="corpo">
         <fieldset>
   <legend class="field">Lançamento
   
            </legend>
   <table width="100%" height="470" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="62" height="41">CRM:</td>
                       <td width="144" class="style8">
                           <asp:TextBox ID="txtReferencia" runat="server" 
                               Columns="10" Enabled="False" AutoPostBack="True"></asp:TextBox>
                       </td>
                       <td colspan="2"><asp:TextBox ID="txtDescricao" runat="server" Columns="24"></asp:TextBox> 
                       </td>
                       <td width="358">
                           <asp:RadioButtonList ID="select_cli_forn" runat="server" 
                               RepeatDirection="Horizontal">
                               <asp:ListItem Selected="True">Cliente</asp:ListItem>
                               <asp:ListItem>Fornecedor</asp:ListItem>
                           </asp:RadioButtonList>
                           <asp:TextBox ID="txtData" runat="server" Columns="2" Enabled="False" 
                               Visible="False"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="35">Cli/Forn:</td>
                       <td class="style8"><asp:TextBox ID="txtCli_Forn_ID" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="3"><asp:TextBox ID="txtCli_Forn_Nome" runat="server" Columns="44"></asp:TextBox> &nbsp;&nbsp;
                         <a href="javascript:Cliente('../Ferramentas/MiniConsulta/Consulta_Cliente.aspx');"><img src="../images2/search.png" border="0"/></a>
                         </td>
                     </tr>
                     <tr>
                       <td height="20" colspan="5"><div class="separacao"></div></td>
                     </tr>
                     <tr>
                       <td height="16" colspan="5">Assunto:</td>
                     </tr>
                     <tr>
                       <td height="26" colspan="5">
                           <asp:TextBox ID="txtAssunto" runat="server" 
                               Columns="68"></asp:TextBox></td>
                     </tr>
                     <tr>
                       <td height="33" colspan="5" class="style1"><span class="style8">Texto:</span></td>
                     </tr>
                     <tr>
                       <td height="33" colspan="5" class="style1">
                           <asp:TextBox ID="txtTexto" 
                               runat="server" Columns="85" TextMode="MultiLine" Rows="7"></asp:TextBox></td>
                     </tr>
                     <tr>
                       <td height="26" colspan="5"><div class="separacao"></div></td>
                     </tr>
                     <tr>
                       <td height="26" colspan="3">
                           <asp:RadioButtonList ID="status_resposta" runat="server" 
                               RepeatDirection="Horizontal">
                               <asp:ListItem Selected="True">Pendente</asp:ListItem>
                               <asp:ListItem>Resolvido</asp:ListItem>
                           </asp:RadioButtonList>
                         </td>
                       <td width="144" align="right" class="style6">Data Solução:</td>
                       <td class="style4">
                           <asp:TextBox ID="txtDtResposta" runat="server" Columns="10" 
                               Enabled="False"></asp:TextBox>&nbsp;(7 Dias úteis)&nbsp;
                           <asp:TextBox ID="txtData0" runat="server" Columns="2" Enabled="False" 
                               Visible="False"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="26" colspan="5">Solução:</td>
                     </tr>
                     <tr>
                       <td height="26" colspan="5"><span class="style4">
                         <asp:TextBox ID="txtResposta" runat="server" Columns="68"></asp:TextBox>
                       </span></td>
                     </tr>
                   </table>
         </fieldset>

         <br />

          <fieldset>
           <legend class="field">Botões de Ação</legend>
           <table width="100%" border="0" cellpadding="0" cellspacing="5">
             <tr>
               <td width="81">
                   <asp:Button class='button_form' ID="btnGravar" runat="server" onclick="btnGravar_Click" Text="Gravar" />
                 </td>
               <td width="80">&nbsp;
                   </td>
               <td width="205">&nbsp;
                   </td>
               <td width="215">&nbsp;</td>
               <td width="75">
                   <asp:Button class='button_form' ID="btnHelp" runat="server" Text="Help" />
                 </td>
               <td width="67">
                   <asp:Button class='button_form' ID="btnSair" runat="server" Text="Sair" />
                 </td>
             </tr>
           </table>
         </fieldset>
               

               </div>
     </form>

</body>
</html>
