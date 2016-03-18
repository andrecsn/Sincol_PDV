<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backup.aspx.cs" Inherits="Projeto.Operacoes.backup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Backup do Sistema</title>

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

</head>
<body>

     <form id="form1" runat="server">
       <div class="corpo">
         <fieldset>
   <legend class="field">Backup do Sistema</legend>
                   
                   <table width="100%" height="182" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="21">Salvar Em:</td>
                       <td>&nbsp;</td>
                     </tr>
                     <tr>
                       <td>
                           <asp:FileUpload ID="txtCaminho" runat="server" />
                         </td>
                       <td>&nbsp;</td>
                     </tr>
                     <tr>
                       <td>Nome do Arquivo:</td>
                       <td>&nbsp;</td>
                     </tr>
                     <tr>
                       <td width="434">
                           <asp:TextBox ID="txtNomeArquivo" runat="server" Columns="55"></asp:TextBox>
                         </td>
                       <td width="898">&nbsp;</td>
                     </tr>
                     <tr>
                       <td colspan="2">&nbsp;</td>
                     </tr>
                     <tr>
                       <td colspan="2">
                           <asp:Button class='button_form' ID="btnbackup" runat="server" Text="Realizar Backup" />
                         </td>
                     </tr>
                   </table>
         </fieldset>
               </div>
     </form>

</body>
</html>
