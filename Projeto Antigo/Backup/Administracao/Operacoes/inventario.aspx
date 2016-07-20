<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Projeto.Operacoes.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Inventário</title>

        <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../css/estilos_formulario/css/estilo.css" type="text/css" />
	
	<script type="text/javascript" src="../css/estilos_formulario/js/jquery.js" ></script>
	<script type="text/javascript" src="../css/estilos_formulario/jquery.jqtransform.js" ></script>
	<script language="javascript">
	    $(function () {
	        $('form').jqTransform({ imgPath: 'jqtransformplugin/img/' });
	    });
	</script>
<!--FIM Estilos de Formulário-->

    <style type="text/css">
        .style1
        {
            width: 160px;
        }
    </style>

</head>
<body>

    <form id="form1" runat="server">
      <div class="corpo">
        <fieldset>
<legend class="field">Inventário</legend>

   <table width="100%" height="182" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="160" height="21" class="style1">Inventário:</td>
                       <td width="154"><span class="style1">
                         <asp:TextBox ID="txtReferencia" runat="server" Columns="10"></asp:TextBox>
                       </span></td>
                       <td colspan="2"><span class="style1">
                         <asp:TextBox ID="txtDescricao" runat="server" Columns="10"></asp:TextBox>
                       </span></td>
                     </tr>
                     <tr>
                       <td class="style1">Produto:</td>
                       <td><asp:TextBox ID="txtProdReferencia" runat="server" Columns="10" 
                               style="margin-left: 0px"></asp:TextBox></td>
                       <td colspan="2">
                           <asp:TextBox ID="txtProdDescricao" runat="server" Columns="55" 
                               style="margin-left: 0px"></asp:TextBox></td>
                     </tr>
                     <tr>
                       <td>&nbsp;</td>
                       <td>Quantidade:</td>
                       <td width="301">&nbsp;</td>
                       <td width="118">&nbsp;</td>
                     </tr>
                     <tr>
                       <td>&nbsp;</td>
                       <td><asp:TextBox ID="txtProdQuantidade" runat="server" Columns="10" 
                               style="margin-left: 0px"></asp:TextBox></td>
                       <td>&nbsp;</td>
                       <td><asp:Button class='button_form' ID="btnIncluir" runat="server" Text="Incluir"/></td>
                     </tr>
                     <tr>
                       <td colspan="4">
                           <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                               ForeColor="Black" GridLines="Horizontal">
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

        <br />

         
      </div>
    </form>

</body>
</html>
