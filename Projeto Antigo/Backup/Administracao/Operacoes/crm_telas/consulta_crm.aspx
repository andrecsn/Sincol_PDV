<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta_crm.aspx.cs" Inherits="Projeto.Operacoes.crm_telas.WebForm1" Culture="auto" UICulture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Consulta CRM</title>

    <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../../css/estilos_formulario/css/estilo.css" type="text/css" />

    <!--Calendário TextBox-->
        <script type="text/javascript" src="../../css/Calendario/js/jquery.js"></script>
		<script type="text/javascript" src="../../css/Calendario/js/jquery.click-calendario-1.0-min.js"></script>		
        <link href="../../css/Calendario/css/jquery.click-calendario-1.0.css" rel="stylesheet" type="text/css"/>

    <script type="text/javascript" src="../../Ferramentas/Uteis.js" ></script>
	<script type="text/javascript" src="../../css/estilos_formulario/jquery.jqtransform.js" ></script>
	<script type="text/javascript">

	    $(document).ready(function () {
	        $('form').jqTransform(
            function () {
                { imgPath: 'jqtransformplugin/img/' }
            }
            );

            $('.calendario1').focus(function () {
                $(this).calendario({
                    target: '.calendario1'
                });
            });


            $('.calendario2').focus(function () {
                $(this).calendario({
                    target: '.calendario2'
                });
            });

        });


        
        
        
	</script>
<!--FIM Estilos de Formulário-->

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

     <form id="form1" runat="server">
       <div class="corpo">


           <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>

         <fieldset>
   <legend class="field">Consulta CRM
   
                   </legend>
   <table width="100%" height="134" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="100" height="22">Período:</td>
                       <td width="144">  
                            <asp:TextBox class="calendario1" ID="txtPeriodo1" runat="server"  Columns="15"></asp:TextBox>
                       </td>
                       <td width="14">a</td>
                       <td width="170">
                       <asp:TextBox class="calendario2" ID="txtPeriodo2" runat="server" Columns="15"></asp:TextBox></td>
                       <td colspan="2">
                           <asp:RadioButtonList ID="select_clie_forn" runat="server" 
                               RepeatDirection="Horizontal">
                         <asp:ListItem Selected="True">Cliente</asp:ListItem>
                         <asp:ListItem>Fornecedor</asp:ListItem>
                       </asp:RadioButtonList></td>
                     </tr>
                     <tr>
                       <td height="36">Clie/Forn</td>
                       <td colspan="5">
                           <asp:TextBox ID="txtNome" runat="server"  Columns="28"></asp:TextBox> &nbsp;&nbsp;
                           <a href="javascript:Cliente('../../Ferramentas/MiniConsulta/Consulta_Cliente.aspx');"><img src="../../images2/search.png" border="0"/></a>
                       </td>
                     </tr>
                     <tr>
                       <td height="24">Assunto:</td>
                       <td colspan="4"><asp:TextBox ID="txtAssunto" runat="server" Columns="33"></asp:TextBox></td>
                       <td width="249">
                               <asp:Button class='button_form' ID="btnBuscar" runat="server" 
                               Text="Filtrar" onclick="btnBuscar_Click" />
                               
                               <asp:Button class='button_form' ID="btnTodos" runat="server" 
                               Text="Todos" onclick="btnTodos_Click" />
                               </td>
                     </tr>
                     <tr>
                       <td height="24" colspan="6" valign="top"><div class="separacao"></div></td>
        </tr>
           </table>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
         <asp:GridView ID="GridView1" runat="server" BackColor="White"
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                               ForeColor="Black" Width="100%" AutoGenerateColumns="false" EmptyDataText="Nenhum Registro Encontrado">
           <Columns>
             <asp:BoundField DataField="CRM_CODIGO" HeaderText="Código" />
             <asp:BoundField DataField="CRM_DESCRICAO" HeaderText="Descrição" />
             <asp:BoundField DataField="CRM_SELECT_CLIE_FORN" HeaderText="Cli ou Forn" />
             <asp:BoundField DataField="CLIE_FORN_NOME" HeaderText="Nome" />
             <asp:BoundField DataField="DATA" HeaderText="Data" />
             </Columns>
           <FooterStyle BackColor="#CCCC99" ForeColor="Black" />           
           <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />           
           <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />           
           <SelectedRowStyle BackColor="#999999" Font-Bold="True" ForeColor="White" />
           <SortedAscendingCellStyle BackColor="#F7F7F7" />
           <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
           <SortedDescendingCellStyle BackColor="#E5E5E5" />
           <SortedDescendingHeaderStyle BackColor="#242121" />
         </asp:GridView>
       </ContentTemplate>
       <Triggers>
         <asp:AsyncPostBackTrigger ControlID="btnBuscar" />
           <asp:AsyncPostBackTrigger ControlID="btnTodos" />
       </Triggers>
     </asp:UpdatePanel>
         </fieldset>
         <br />

               </div>
     </form>

</body>
</html>
