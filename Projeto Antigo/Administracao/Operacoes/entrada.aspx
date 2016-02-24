<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="entrada.aspx.cs" Inherits="Projeto.Cadastros.entrada" %>

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
   <legend class="field">Entrada de Produtos</legend>
   
            <table width="100%" height="452" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="49"> <asp:Button class='button_form' ID="btnIncluir0" runat="server" 
                               Text="Compras" /></td>
                       <td width="144" class="style8"><asp:TextBox ID="txtReferencia" runat="server" Columns="10"></asp:TextBox></td>
                       <td><asp:TextBox ID="txtData" runat="server" Columns="10"></asp:TextBox></td>
                       <td colspan="3">&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="32">Fornecedor:</td>
                       <td class="style8"><asp:TextBox ID="txtFornecedor" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="4"><asp:TextBox ID="txtFornNome" runat="server" Columns="45"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="20" colspan="6"><div class="separacao"></div></td>
                     </tr>
                     <tr>
                       <td width="57" height="55">Produto:</td>
                       <td class="style8"><asp:TextBox ID="txtProdCod" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="4"><asp:TextBox ID="txtprodNome" runat="server" Columns="45"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="16">&nbsp;</td>
                       <td class="style8">Quantidade:</td>
                       <td width="144" class="style5">Valor Unitário:</td>
                       <td width="144" class="style6">Valor Total:</td>
                       <td width="76" class="style4">&nbsp;</td>
                       <td width="158" class="style7">&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="26">&nbsp;</td>
                       <td class="style8">
                           <asp:TextBox ID="txtQuandtidade" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td class="style5">
                           <asp:TextBox ID="txtVal_Unitario" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td class="style6">
                           <asp:TextBox ID="txtVal_Total" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td class="style4">&nbsp;
                           </td>
                       <td class="style7"> <asp:Button class='button_form' ID="btnIncluir" runat="server" Text="Incluir" /></td>
                     </tr>
                     <tr>
                       <td colspan="6" class="style1"></td>
                     </tr>
                     <tr>
                       <td height="26" colspan="6">
                           <asp:GridView ID="GridView2" runat="server" BackColor="White" 
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                               ForeColor="Black" GridLines="Horizontal" Width="716px" 
                               AutoGenerateColumns="False" EnableTheming="True" UseAccessibleHeader="False">
                               <EmptyDataTemplate>
                                   Teste<br /> Teste
                               </EmptyDataTemplate>
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
                       <td height="26" colspan="6"><div class="separacao"></div></td>
                     </tr>
                     <tr>
                       <td height="26" colspan="2">Forma de Pagamento:</td>
                       <td class="style5">Vencimento:</td>
                       <td class="style6">Valor da Parcela:</td>
                       <td class="style4" colspan="2">Total:</td>
                     </tr>
                     <tr>
                       <td height="26" colspan="2">
                           <asp:DropDownList ID="DropDownList1" runat="server">
                               <asp:ListItem>A Vista</asp:ListItem>
                               <asp:ListItem>Parcelado</asp:ListItem>
                           </asp:DropDownList>
                         </td>
                         <td class="style5">
                           <asp:TextBox ID="txtVencimento" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td class="style6">
                           <asp:TextBox ID="txtVal_Parcela" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td class="style4" colspan="2">
                           <asp:TextBox ID="txtTotal" runat="server" Columns="10" Enabled="False"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="26" colspan="6">&nbsp;</td>
                     </tr>
                     <tr>
                       <td colspan="6">
                           <asp:GridView ID="GridView3" runat="server" BackColor="White" 
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                               ForeColor="Black" GridLines="Horizontal" Width="715px">
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
                   </table>
         </fieldset>

                  </br>
         
                 <fieldset>
                   <legend class="field">Botões de Ação</legend>
                   <table width="100%" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="88"> <asp:Button class='button_form' ID="btnGravar" runat="server" Text="Finalizar" /></td>
                       <td width="346">&nbsp;</td>
                       <td width="97"> <asp:Button class='button_form' ID="btnAjuda" runat="server" Text="Help" onclick="btnAjuda_Click" /></td>
                       <td width="79"> <asp:Button class='button_form' ID="btnSair" runat="server" Text="Sair" /></td>
                     </tr>
                   </table>
         </fieldset>
                 <p></p>
               </div>
     </form>

</body>
</html>
