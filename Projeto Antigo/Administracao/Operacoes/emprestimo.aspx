<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emprestimo.aspx.cs" Inherits="Projeto.Operacoes.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../css/estilos_formulario/css/estilo.css" type="text/css" />
    <script type="text/javascript" src="../css/estilos_formulario/js/jquery.js" ></script>
    <script type="text/javascript" src="../Ferramentas/Uteis.js" ></script>
	<script type="text/javascript" src="../css/estilos_formulario/jquery.jqtransform.js" ></script>

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
   <legend class="field">Emprestimo</legend>
   
            <table width="100%" height="400" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="17"><span class="style8">Emprestimo:</span></td>
                       <td width="144" class="style8">Dt-Emprestimo:</td>
                       <td>Dt-Previsão:</td>
                       <td><span class="style8">Dt-Devolução:</span></td>
                       <td width="131">&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="43"><span class="style8">
                         <asp:TextBox ID="txtReferencia" runat="server" Columns="10"></asp:TextBox>
                       </span></td>
                       <td class="style8"><asp:TextBox ID="txtDTEmprestimo" runat="server" Columns="10"></asp:TextBox></td>
                       <td><asp:TextBox ID="txtDTPrevisao" runat="server" Columns="10"></asp:TextBox></td>
                       <td><span class="style8">
                         <asp:TextBox ID="txtDTDevolucao" runat="server" Columns="10"></asp:TextBox>
                       </span></td>
                       <td>&nbsp;</td>
              </tr>
                     <tr>
                       <td height="25" colspan="5" valign="middle"><div class="separacao"></div></td>
                     </tr>
                     <tr>
                       <td height="32">Cliente:</td>
                       <td class="style8"><asp:TextBox ID="txtCliID" runat="server" Columns="10"></asp:TextBox>
                       </td>
                       <td colspan="3"><asp:TextBox ID="txtCliNome" runat="server" Columns="45"></asp:TextBox>
                       </td>
                     </tr>
                     <tr>
                       <td height="20" colspan="5"><div class="separacao"></div></td>
                     </tr>
                     <tr>
                       <td width="147" height="55">Produto:</td>
                       <td class="style8"><asp:TextBox ID="txtProdCod" runat="server" Columns="10"></asp:TextBox>
                       </td>
                       <td colspan="3"><asp:TextBox ID="txtprodNome" runat="server" Columns="45"></asp:TextBox>
                       </td>
                     </tr>
                     <tr>
                       <td height="16">&nbsp;</td>
                       <td class="style8">Quantidade:</td>
                       <td width="144" class="style5">Valor Unitário:</td>
                       <td colspan="2" class="style6">Valor Total:</td>
                     </tr>
                     <tr>
                       <td height="26">&nbsp;</td>
                       <td class="style8">
                           <asp:TextBox ID="txtQuandtidade" runat="server" Columns="10"></asp:TextBox>
                       </td>
                       <td class="style5">
                           <asp:TextBox ID="txtVal_Unitario" runat="server" Columns="10"></asp:TextBox>
                       </td>
                       <td width="162" class="style6">
                           <asp:TextBox ID="txtVal_Total" runat="server" Columns="10"></asp:TextBox>
                       </td>
                       <td class="style4">                         <asp:Button class='button_form' ID="btnIncluir" runat="server" Text="Incluir" /></td>
                     </tr>
                     <tr>
                       <td height="12" colspan="5" class="style1"><div class="separacao"></div></td>
              </tr>
                     <tr>
                       <td height="34" colspan="5" class="style1">
                           <asp:GridView ID="GridView1" runat="server" BorderStyle="None" 
                               BorderWidth="1px" CellPadding="4" GridLines="Horizontal" Width="716px">
                               <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                               <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                               <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                               <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                               <SortedAscendingCellStyle BackColor="#F7F7F7" />
                               <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                               <SortedDescendingCellStyle BackColor="#E5E5E5" />
                               <SortedDescendingHeaderStyle BackColor="#242121" />
                           </asp:GridView>
                       </td>
                     </tr>
                     <tr>
                       <td height="12" colspan="5" class="style1"><div class="separacao"></div></td>
                     </tr>
                     <tr>
                       <td height="34" colspan="5" class="style1">
                           <asp:TextBox ID="txtObs" runat="server" Columns="89" Rows="8" 
                               TextMode="MultiLine"></asp:TextBox>
                       </td>
                     </tr>
           </table>
         </fieldset>

                  </br>
         
                 <fieldset>
                   <legend class="field">Botões de Ação</legend>
                   <table width="100%" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="39"><asp:Button class='button_form' ID="btnGravar" runat="server" 
                               Text="Realizar Devolução" /></td>
                       <td><asp:Button class='button_form' ID="btnGravar1" runat="server" 
                               Text="Gravar" /></td>
                       <td><asp:Button class='button_form' ID="btnAjuda" runat="server" Text="Help" onclick="btnAjuda_Click" /></td>
                     </tr>
                     <tr>
                       <td width="326" height="43"><asp:Button class='button_form' ID="btnGravar0" runat="server" 
                               Text="Efetuar Vendas" /></td>
                       <td width="298">
                           <asp:Button class='button_form' ID="btnGravar2" runat="server" 
                               Text="Excluir" /></td>
                       <td width="114"><asp:Button class='button_form' ID="btnSair" runat="server" Text="Sair" /></td>
                     </tr>
                   </table>
         </fieldset>
                 <p></p>
               </div>
     </form>

</body>
</html>
