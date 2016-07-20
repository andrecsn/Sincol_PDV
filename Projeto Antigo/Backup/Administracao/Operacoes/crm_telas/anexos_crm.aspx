<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anexos_crm.aspx.cs" Inherits="Projeto.Operacoes.crm_telas.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Imagens e Documentos</title>

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
            height: 66px;
        }
        .style2
        {
            height: 22px;
        }
    </style>

</head>
<body>

     <form id="form1" runat="server">
       <div class="corpo">
         <fieldset>
   <legend class="field">Imagens e Documentos
   
                   </legend><table width="100%" height="89" border="0" cellpadding="0" 
                 cellspacing="5" class="style1">
                     <tr>
                       <td width="166" height="21">CRM:</td>
                       <td width="575" colspan="2">Assunto:</td>
                     </tr>
                     <tr>
                       <td height="33" class="style2">
                           <asp:TextBox ID="txtReferencia" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td colspan="2">
                           <asp:TextBox ID="txtDescricao" runat="server" Columns="55"></asp:TextBox>
                         </td>
                     </tr>
                     </table>
                   <table width="100%" border="0" cellpadding="0" cellspacing="5" 
                 style="height: 264px">
                     <tr>
                       <td height="27">Documento:</td>
                     </tr>
                     <tr>
                       <td height="36">
                         <asp:FileUpload ID="FileUpload1" runat="server" />                       </td>
                     </tr>
                     <tr>
                       <td height="204">
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
                           </asp:GridView>                       </td>
                     </tr>
                   </table>
         </fieldset>
               </div>
     </form>

</body>
</html>
