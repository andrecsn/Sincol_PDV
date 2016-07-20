<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perfil_acesso.aspx.cs" Inherits="Projeto.Cadastros.usuario_telas.perfil_acesso" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Perfil de Acesso</title>

        <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../../css/estilos_formulario/css/estilo.css" type="text/css" />
    <script type="text/javascript" src="../../Ferramentas/Uteis.js" ></script>
	
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
   <legend class="field">Cadastro de Perfil de Acesso</legend>
   
             <asp:ScriptManager ID="ScriptManager1" runat="server">
             </asp:ScriptManager>


					<table width="760px" height="143" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="84" height="30">Perfil:</td>
                       <td width="323"><asp:DropDownList ID="listPerfil" runat="server">
                         <asp:ListItem>WEB</asp:ListItem>
                         <asp:ListItem>LOJA</asp:ListItem>
                       </asp:DropDownList>&nbsp;&nbsp; 
                       <a href="javascript:Popup('../../Ferramentas/MiniConsulta/MiniConsulta.aspx?Tabela=Perfil_Acesso&ColCod=pera_codigo&ColDesc=pera_descricao');"><img 
                               src="../../images2/mais.png" border="0"/></a></td>
                       <td width="327"><asp:CheckBox ID="checkCarregaGrid" runat="server"  Text="Visualizar Cadastro" 
                               OnCheckedChanged="checkCarregaGrid_CheckedChanged" AutoPostBack="true" /></td>
                     </tr>
                     <tr>
                       <td height="33">Transação:</td>
                       <td colspan="2"><asp:DropDownList ID="listTransacao" runat="server">
                         <asp:ListItem>WEB</asp:ListItem>
                         <asp:ListItem>LOJA</asp:ListItem>
                       </asp:DropDownList>&nbsp;&nbsp;
                       <a href="javascript:Popup('../../Ferramentas/MiniConsulta/MiniConsulta.aspx?Tabela=Transacao&ColCod=trn_Codigo&ColDesc=trn_descricao');"><img 
                               src="../../images2/mais.png" border="0"/></a>
                       </td>
                     </tr>
                     <tr>
                       <td height="32" colspan="3">
                       
                       <fieldset>
   						<legend class="field">Permissão</legend>
                         <table width="100%" height="71" border="0" cellpadding="0" cellspacing="0" align="left">
                           <tr>
                             <td width="131"><asp:CheckBox ID="checkConsultar" runat="server" Text="Consultar" value="1" /></td>
                             <td width="119"><asp:CheckBox ID="checkExcluir" runat="server" Text="Excluir" /></td>
                             <td width="150"><asp:CheckBox ID="checkAlterar" runat="server" Text="Alterar" /></td>
                             <td width="170"><asp:CheckBox ID="checkvisu_totais" runat="server" Text="Visualizar Totais" /></td>
                             <td width="176">&nbsp;</td>
                           </tr>
                           <tr>
                             <td><asp:CheckBox ID="checkIncluir" runat="server" Text="Incluir"/></td>
                             <td><asp:CheckBox ID="checkImprimir" runat="server" Text="Imprimir" /></td>
                             <td><asp:CheckBox ID="checkProcessar" runat="server" Text="Processar" /></td>
                             <td><asp:CheckBox ID="checkLiberar" runat="server" Text="Liberar" /></td>
                             <td align="right"><asp:Button class='button_form' ID="btnGravar" runat="server" 
                                     Text="Gravar" onclick="btnGravar_Click"/></td>
                           </tr>
                         </table>
                      </fieldset>
                       
                       </td>
           </table>
                         
                           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                           <ContentTemplate>
                           
                     <table width="100%" border="0" cellpadding="0" cellspacing="5">
                     
                     <tr><td><div class="separacao"></div></td></tr>
                     
                     
                     <tr>
                       <td height="31" colspan="3">
                           <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="6" Width="900px" 
                               ForeColor="Black" AutoGenerateColumns="False">
                               <Columns>
                                   <asp:BoundField DataField="PERFIL" HeaderText="Perfil" />
                                   <asp:BoundField DataField="TRANSAÇÃO" HeaderText="Transação" />
                                   <asp:CheckBoxField DataField="CONSULTAR" HeaderText="Consultar">
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                                   <asp:CheckBoxField DataField="EXCLUIR" HeaderText="Excluir" >
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                                   <asp:CheckBoxField DataField="ALTERAR" HeaderText="Alterar" >
                                   <HeaderStyle HorizontalAlign="Center" />
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                                   <asp:CheckBoxField DataField="VISUALIZAR" HeaderText="Visualizar">
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                                   <asp:CheckBoxField DataField="INCLUIR" HeaderText="Incluir">
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                                   <asp:CheckBoxField DataField="IMPRIMIR" HeaderText="Imprimir">
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                                   <asp:CheckBoxField DataField="PROCESSAR" HeaderText="Processar">
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                                   <asp:CheckBoxField DataField="LIBERAR" HeaderText="Liberar">
                                   <ItemStyle HorizontalAlign="Center" />
                                   </asp:CheckBoxField>
                               </Columns>
                               <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                               <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                               <PagerStyle BackColor="White" ForeColor="Black" />
                               <SelectedRowStyle BackColor="#999999" Font-Bold="True" ForeColor="White" />
                               <SortedAscendingCellStyle BackColor="#F7F7F7" />
                               <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                               <SortedDescendingCellStyle BackColor="#E5E5E5" />
                               <SortedDescendingHeaderStyle BackColor="#242121" />
                           </asp:GridView>
                         </td>
                     </tr>
                   </table>
                   </ContentTemplate>
                               <Triggers>
                                   <asp:AsyncPostBackTrigger ControlID="checkCarregaGrid" 
                                       EventName="CheckedChanged" />
                                   <asp:AsyncPostBackTrigger ControlID="btnGravar" EventName="Click" />
                               </Triggers>
                   </asp:UpdatePanel>
                   
         </fieldset>
               </div>
     </form>

</body>
</html>
