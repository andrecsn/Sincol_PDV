<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="estoque.aspx.cs" Inherits="Projeto.Cadastros.produto_telas.WebForm5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Estoque</title>

        <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../../css/estilos_formulario/css/estilo.css" type="text/css" />
	
	<script type="text/javascript" src="../../css/estilos_formulario/js/jquery.js" ></script>
	<script type="text/javascript" src="../../css/estilos_formulario/jquery.jqtransform.js" ></script>
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
   <legend class="field">Estoque
   
                   </legend><table width="100%" height="182" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="21" colspan="2">Referência:</td>
                       <td colspan="2">Descrição:</td>
                     </tr>
                     <tr>
                       <td colspan="2">
                           <asp:TextBox ID="txtReferencia" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="2">
                           <asp:TextBox ID="txtDescricao" runat="server" Width="341px" Columns="55"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td colspan="3">Intervalo de:</td>
                       <td>Tipo de Saída</td>
                     </tr>
                     <tr>
                       <td width="107">
                           <asp:TextBox ID="txtIntervalo" runat="server" Width="70px" Columns="10"></asp:TextBox>
                         </td>
                       <td width="23">                       Até</td>
                       <td width="167">
                           <asp:TextBox ID="txtAte" runat="server" Width="53px" Columns="10"></asp:TextBox>
                         </td>
                       <td>
                           <asp:DropDownList ID="txtTipoSaida" runat="server">
                               <asp:ListItem>WEB</asp:ListItem>
                               <asp:ListItem>LOJA</asp:ListItem>
                           </asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                       <td colspan="4">&nbsp;</td>
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
               </div>
     </form>

</body>
</html>
