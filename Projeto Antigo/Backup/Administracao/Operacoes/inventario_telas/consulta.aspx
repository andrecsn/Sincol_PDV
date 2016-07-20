<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="Projeto.Operacoes.inventario_telas.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta CRM</title>

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

    <style type="text/css">
        .style1
        {
            height: 23px;
        }
    </style>

</head>
<body>

     <form id="form1" runat="server">
       <div class="corpo">
         <fieldset>
   <legend class="field">Consulta Inventário
   
                   </legend>
   <table width="100%" height="98" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="109" height="44">Período:</td>
                       <td width="174"><asp:TextBox ID="txtPeriodo1" runat="server"  Columns="15"></asp:TextBox></td>
                       <td width="42">Até</td>
                       <td width="191"><asp:TextBox ID="txtPeriodo2" runat="server" Columns="15"></asp:TextBox></td>
                       <td width="212" colspan="2">&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="39">Produto:</td>
                       <td colspan="5">
                           <asp:TextBox ID="txtNome" runat="server"  Columns="37"></asp:TextBox>
                         </td>
                     </tr>
                   </table>
         </fieldset>

         <br />

               </div>
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
     </form>

</body>
</html>
