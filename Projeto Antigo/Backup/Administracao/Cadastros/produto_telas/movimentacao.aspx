<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movimentacao.aspx.cs" Inherits="Projeto.Cadastros.produto_telas.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Movimentação</title>

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
   <legend class="field">Movimentação

   <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
   
                   </legend><table width="100%" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td height="21" colspan="2">Referência:</td>
                       <td colspan="3">Descrição:</td>
                     </tr>
                     <tr>
                       <td colspan="2">
                           <asp:TextBox ID="txtReferencia" runat="server" Columns="10" placeholder="Ex. 001"></asp:TextBox>
                         </td>
                       <td colspan="3">
                           <asp:TextBox ID="txtDescricao" runat="server" Width="344px" Columns="55" placeholder="Descrição completa do produto"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td colspan="5">Intervalo de:</td>
                     </tr>
                     <tr>
                       <td width="11%">
                           <asp:TextBox ID="txtDtInicio" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td width="35%">Até</td>
                       <td width="13%">
                           <asp:TextBox ID="txtDtFinal" runat="server" Columns="10"></asp:TextBox>
                         </td>
                       <td width="32%">
                           <asp:CheckBox ID="checkEntrada" runat="server" Text="Entrada" />&nbsp;&nbsp;&nbsp;
                           <asp:CheckBox ID="checkSaida" runat="server" Text="Saida" />&nbsp;&nbsp;&nbsp;
                         <asp:CheckBox ID="checkEmprestimo" runat="server" 
                               Text="Emprestimo" />                         </td>
                       <td width="9%">
                       <asp:Button class='button_form' ID="btnBuscar" runat="server" Text="Listar" onclick="btnBuscar_Click" />
                       </td>
                     </tr>
                     <tr>
                       <td colspan="5"><div class="separacao"></div></td>
                     </tr>

                     <tr>
                       <td colspan="5">&nbsp;</td>
                     </tr>

                     <tr>
                       <td colspan="5">
                           
                           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
         <asp:GridView ID="GridView1" runat="server" BackColor="White"
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                               ForeColor="Black" Width="100%" AutoGenerateColumns="false" EmptyDataText="Nenhum Registro Encontrado">
           <Columns>
             <asp:BoundField DataField="PROD_REFERENCIA" HeaderText="#" />
             <asp:BoundField DataField="PROD_DESCRICAO" HeaderText="Descrição" />
             <asp:BoundField DataField="PROD_MODELO" HeaderText="Modelo" />
             <asp:BoundField DataField="PROD_MARCA" HeaderText="Marca" />
             <asp:BoundField DataField="DESCRICAO" HeaderText="Fabricante" />
             <asp:BoundField DataField="PROD_DATA_CADASTRO" HeaderText="Data" />
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
       </Triggers>
     </asp:UpdatePanel>

                         </td>
                     </tr>
                   </table>
         </fieldset>
               </div>
     </form>

</body>
</html>

