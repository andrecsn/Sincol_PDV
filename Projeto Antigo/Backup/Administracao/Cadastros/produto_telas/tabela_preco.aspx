<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabela_preco.aspx.cs" Inherits="Projeto.Cadastros.produto_telas.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabela de Preço</title>

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
   <legend class="field">Tabela de Preço
   
                   </legend><table width="100%" height="182" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="21">Referência:</td>
                       <td colspan="2">Descrição:</td>
                     </tr>
                     <tr>
                       <td>
                           <asp:TextBox ID="txtReferencia" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="2">
                           <asp:TextBox ID="txtDescricao" runat="server" Columns="55"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td>Data:</td>
                       <td>Preço Loja:</td>
                       <td>Preço WEB:</td>
                     </tr>
                     <tr>
                       <td width="156">
                           <asp:TextBox ID="txtData" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td width="144">
                           <asp:TextBox ID="txtPrecoLoja" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td width="438">
                           <asp:TextBox ID="txtPrecoWeb" runat="server" Columns="10"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td colspan="3">&nbsp;</td>
                     </tr>
                     <tr>
                       <td colspan="3">
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
