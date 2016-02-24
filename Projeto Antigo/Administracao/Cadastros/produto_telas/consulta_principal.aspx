<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta_principal.aspx.cs" Inherits="Projeto.Cadastros.produto_telas.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Consulta Principal</title>

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
   <legend class="field">Consulta Principal
   
                   </legend>

                   <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                   
                   <table width="100%" height="147" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="18%" height="21">Referência:</td>
                       <td colspan="4">Descrição:</td>
                     </tr>
                     <tr>
                       <td height="29">
                           <asp:TextBox ID="txtReferencia" runat="server" Columns="10" placeholder="Ex. 001"></asp:TextBox>
                         </td>
                       <td colspan="4">
                           <asp:TextBox ID="txtDescricao" runat="server" Width="401px" Columns="55" placeholder="Descrição completa do produto"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="28">Origem:</td>
                       <td width="20%">Modelo:</td>
                       <td width="20%">Marca:</td>
                       <td width="27%">Fabricante:</td>
                       <td width="15%">&nbsp;</td>
                     </tr>
                     <tr>
                       <td height="29">
                           <asp:DropDownList ID="listOrigem" runat="server" Width="80px" AppendDataBoundItems="True">
                               <asp:ListItem Text="--Escolha--" Value=""></asp:ListItem>
                               <asp:ListItem>WEB</asp:ListItem>
                               <asp:ListItem>LOJA</asp:ListItem>
                           </asp:DropDownList>
                       </td>
                       <td>
                           <asp:TextBox ID="txtModelo" runat="server" Columns="12"></asp:TextBox>
                       </td>
                       <td>
                           <asp:TextBox ID="txtMarca" runat="server" Columns="12"></asp:TextBox>
                       </td>
                       <td>
                       <asp:DropDownList ID="listFabricante" runat="server" Width="110px" AppendDataBoundItems="True">
                       <asp:ListItem Text="--Escolha--" Value="0"></asp:ListItem>
                       </asp:DropDownList>
                       </td>
                       <td>
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
             <asp:BoundField DataField="PROD_ORIGEM" HeaderText="Origem" />
             <asp:BoundField DataField="PROD_MODELO" HeaderText="Modelo" />
             <asp:BoundField DataField="PROD_MARCA" HeaderText="Marca" />
             <asp:BoundField DataField="DESCRICAO" HeaderText="Fabricante" />
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

         <br />

               </div>
       
     </form>

</body>
</html>
