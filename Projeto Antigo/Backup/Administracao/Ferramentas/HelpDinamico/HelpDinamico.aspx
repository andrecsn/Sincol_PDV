<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelpDinamico.aspx.cs" Inherits="Projeto.Cadastros.HelpDinamico.HelpDinamico" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SincolPDV - Help Dinâmico</title>


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

    <script language="javascript">

        function OK() {
            var vReturnValue = new Object();
            // vReturnValue.Texto = document.getElementById("Texto").value;

            window.returnValue = vReturnValue;
            window.close();
        }

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtHelp" runat="server" Rows="25" TextMode="MultiLine"  Width="594px"></asp:TextBox>
        <br />
                 <fieldset>
                   <legend class="field">Botões de Ação</legend>
                   <table width="100%" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="88"> <asp:Button class="button_form" ID="btnGravar" runat="server" Text="Gravar" /></td>
                       <td width="89">&nbsp;</td>
                       <td width="346">&nbsp;</td>
                       <td width="346">&nbsp;</td>
                       <td width="97"> &nbsp;</td>
                       <td width="79"> <asp:Button class="button_form" ID="btnSair" runat="server" Text="Sair" OnClientClick="OK();" /></td>
                     </tr>
                   </table>
         </fieldset>
    
    </div>
    </form>
</body>
</html>
