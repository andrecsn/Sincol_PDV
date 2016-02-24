<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuarios.aspx.cs" Inherits="Projeto.Cadastros.usuarios" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
      <title>Cadastro de Usuário</title>

      <style type="text/css">
        .estilo
        {
            border: 1px solid #C10000;
            background-color: #FFEAEA;
            height: auto;
            width: 96%;
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 13px;
            color: #900;
            padding-left: 10px;
            padding-top: 10px;
            margin-left: 10px;
            margin-top: 10px;
            margin-bottom: 10px;
        }
    </style>

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


<body onload="Abre();">

    <form id="form1" runat="server">
      <div class="corpo">
        <fieldset>
<legend class="field">Cadastro de Usuário</legend>


    <asp:ValidationSummary ID="ValidationSummaryCliente" runat="server" HeaderText="<img align='absmiddle' src='../images2/alerta.gif' border='0'/> Verifique as informações abaixo:"
                   ValidationGroup="validaInclui" CssClass="estilo" />

   <table width="100%" height="232" border="0" cellpadding="0" cellspacing="5">
                     <tr>
                       <td width="160" class="style2">Login:</td>
                       <td width="169" class="style3"><span class="style1">
                       <asp:TextBox ID="txtLogin" runat="server" Columns="14"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                               ControlToValidate="txtLogin" ErrorMessage="Campo Login é obrigatorio."
                               ValidationGroup="validaInclui">*</asp:RequiredFieldValidator>
                       </span></td>
                       <td width="45" valign="middle" class="style3">Nome:</td>
                       <td valign="middle" class="style3"><span class="style1">
                       <asp:TextBox ID="txtNome" runat="server" Columns="33" placeholder="Digite o nome completo"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                               ControlToValidate="txtNome" ErrorMessage="Campo Nome é obrigatorio."
                               SetFocusOnError="True" ValidationGroup="validaInclui">*</asp:RequiredFieldValidator>
                       </span></td>
                     </tr>
                     <tr>
                       <td class="style4">Senha:</td>
                       <td class="style5">
                           <asp:TextBox ID="txtSenha" runat="server" Columns="14"
                               style="margin-left: 0px"></asp:TextBox><span class="style1">
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                               ControlToValidate="txtSenha" ErrorMessage="Campo Senha é obrigatorio."
                               SetFocusOnError="True" ValidationGroup="validaInclui">*</asp:RequiredFieldValidator>
                       </span></td>
                       <td colspan="2" class="style5">
                           <asp:CheckBox ID="checkAtivo" runat="server" Text="Ativo" />
                         </td>
                     </tr>
                     <tr>
                       <td height="32">Perfil:</td>
                       <td colspan="2">
                           <asp:DropDownList ID="listPerfilAcesso" runat="server" Width="120px">
                           </asp:DropDownList>
                         </td>
                       <td width="359">
                       <asp:Button class='button_form' ID="btnIncluir" runat="server" Text="Incluir"
                               onclick="btnGravar_Click" ValidationGroup="validaInclui"/>

                       <asp:Button class='button_form' ID="btnLimpar" runat="server" Text="Limpar" onclick="btnLimpar_Click" Visible="False"/>

                       <asp:Button class='button_form' ID="btnAlterar" runat="server" Text="Alterar" onClick="btnAlterar_Click"/>

                       <asp:Button class='button_form' ID="btnExcluir" runat="server" Text="Excluir" onclick="btnExcluir_Click" /> 
                       
                       </td>
                     </tr>
                     
                     <tr>
                     <td colspan="4"><div class="separacao"></div></td>
                     </tr>

                     <tr>
                       <td height="28" colspan="4">
                        <asp:TextBox ID="txtTabela" runat="server" Visible="false" Width="29px"></asp:TextBox>
                        <asp:TextBox ID="txtColCod" runat="server" Visible="false" Width="29px" ></asp:TextBox>
                        <asp:TextBox ID="txtColNome" runat="server" Visible="false" Width="29px"></asp:TextBox>
                        <asp:TextBox ID="txtColLogin" runat="server" Visible="false" Width="29px"></asp:TextBox>
                        <asp:TextBox ID="txtColSenha" runat="server" Visible="false" Width="29px"></asp:TextBox>
                        <asp:TextBox ID="txtColPerfil" runat="server" Visible="false" Width="29px"></asp:TextBox>
                        <asp:TextBox ID="txtColAtivo" runat="server" Visible="false" Width="29px"></asp:TextBox>

                        <asp:TextBox ID="checkAtivo2" runat="server" Visible="false" Width="29px"></asp:TextBox>
                        <asp:TextBox ID="txtCodigo" runat="server" Visible="false" Width="29px"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                       <td height="36" colspan="4">

                           <asp:GridView ID="GridView1" runat="server" BackColor="White"
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4"
                               ForeColor="Black" Width="100%"
                               OnRowCommand="GridView1_Command" DataKeyNames="CODIGO,NOME,LOGIN,SENHA,PERFIL,ATIVO" >
                               <Columns>
                            <asp:CommandField ButtonType="image" SelectImageUrl="~/images2/arrow.png" ShowSelectButton="True"
                               >
                            <ControlStyle CssClass="button" />
                            </asp:CommandField>
                            <asp:BoundField DataField="CODIGO" HeaderText="Código"
                                SortExpression="CODIGO" Visible="False" HeaderStyle-HorizontalAlign="Center">
                                   <FooterStyle HorizontalAlign="Center" />
                                   <HeaderStyle HorizontalAlign="Center" />
                                   </asp:BoundField>
                            <asp:BoundField DataField="NOME" HeaderText="Nome"
                                SortExpression="NOME" Visible="False" />
                                <asp:BoundField DataField="LOGIN" HeaderText="Login"
                                SortExpression="LOGIN" Visible="False" />
                                <asp:BoundField DataField="SENHA" HeaderText="Senha"
                                SortExpression="SENHA" Visible="False" />
                                <asp:BoundField DataField="PERFIL" HeaderText="Perfil"
                                SortExpression="PERFIL" Visible="False" />
                                <asp:BoundField DataField="ATIVO" HeaderText="Ativo"
                                SortExpression="ATIVO" Visible="False" />
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

                         </td>
                     </tr>
                   </table>
        </fieldset>

        <br />


      </div>
    </form>

</body>
</html>
