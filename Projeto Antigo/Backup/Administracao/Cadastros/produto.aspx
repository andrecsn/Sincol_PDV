<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="produto.aspx.cs" Inherits="Projeto.Cadastros.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cadastro de Produto</title>

    <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../css/estilos_formulario/css/estilo.css" type="text/css" />

<!-----------------------------------------Scripts de Validação----------------------------------------->
<script type="text/javascript" src="../js/validacao/jquery-1.7.2.min.js"></script>
<script type="text/javascript" src="../js/validacao/jquery.maskedinput-1.3.min.js"></script>
<script type="text/javascript" src="../js/Sincol.js"></script>
<!-----------------------------------------FIM Scripts de Validação------------------------------------->

    <script type="text/javascript" src="../css/estilos_formulario/js/jquery.js" ></script>
	<script type="text/javascript" src="../css/estilos_formulario/jquery.jqtransform.js" ></script>
	<script type="text/javascript" src="../Ferramentas/Uteis.js" ></script>

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
   <legend class="field">Cadastro de Produtos</legend>
   
                   <table height="353" border="0" cellpadding="0" cellspacing="5">
  <tr>
    <td width="118" height="27">Referência:</td>
    <td colspan="2">Descrição:</td>
    <td width="173"><asp:CheckBox ID="chkAtivo" runat="server" Text="Ativo"/></td>
    <td width="161">&nbsp;</td>
  </tr>
  <tr>
    <td><asp:TextBox Visible="false" ID="txtCodigo" runat="server" Columns="10" 
                               AutoPostBack="True"></asp:TextBox>
                         <asp:TextBox ID="txtReferencia" runat="server" Columns="10" 
                               ontextchanged="txtReferencia_TextChanged" AutoPostBack="True" placeholder="Ex. 001"></asp:TextBox></td>
    <td colspan="4"><asp:TextBox ID="txtDescricao" runat="server" Columns="56" placeholder="Descrição completa do produto"></asp:TextBox></td>
    </tr>
  <tr>
    <td height="25" colspan="2">Fabricante:</td>
    <td width="170">Marca:</td>
    <td>Modelo:</td>
    <td>Origem:</td>
  </tr>
  <tr>
    <td height="36" colspan="2">
    <asp:DropDownList ID="listFabricante" runat="server" Width="110px"></asp:DropDownList>&nbsp;
    <a href="javascript:Popup('../Ferramentas/MiniConsulta/MiniConsulta.aspx?Tabela=Fabricante&ColCod=Fab_Codigo&ColDesc=Fab_descricao');"><img src="../images2/mais.png" border="0"/></a>
    </td>
    <td><asp:TextBox ID="txtMarca" runat="server" Columns="15"></asp:TextBox></td>
    <td><asp:TextBox ID="txtModelo" runat="server" Columns="15"></asp:TextBox></td>
    <td><asp:DropDownList ID="listOrigem" runat="server" Width="120px">
                               <asp:ListItem>LOJA</asp:ListItem>
                               <asp:ListItem>WEB</asp:ListItem>
                           </asp:DropDownList></td>
  </tr>
  <tr>
    <td height="25" colspan="2">Uni. Entrada:</td>
    <td>Esto. Minimo:</td>
    <td>Esto. Maximo:</td>
    <td>Fator:</td>
  </tr>
  <tr>
    <td height="36" colspan="2">
    <asp:DropDownList ID="listUniEntrada" runat="server" Width="110px"></asp:DropDownList>&nbsp;
    <a href=""><a href="javascript:Popup('../Ferramentas/MiniConsulta/MiniConsulta.aspx?Tabela=T_Armazenamento&ColCod=Arm_Codigo&ColDesc=Arm_Estoque');"><img src="../images2/mais.png" border="0"/></a>
    </td>
    <td><asp:TextBox ID="txtEstoMinimo" runat="server" Columns="15" placeholder="Quantidade"></asp:TextBox></td>
    <td><asp:TextBox ID="txtEstoMaximo" runat="server" Columns="15" placeholder="Quantidade"></asp:TextBox></td>
    <td><asp:TextBox ID="txtFator" runat="server" Columns="14"></asp:TextBox></td>
  </tr>
  <tr>
    <td height="21" colspan="2">Uni. Saida:</td>
    <td>Peso:</td>
    <td>Preço Unitário:</td>
    <td>Tipo de Saida:</td>
  </tr>
  <tr>
    <td height="36" colspan="2">
    <asp:DropDownList ID="listUniSaida" runat="server" Width="110px"></asp:DropDownList>&nbsp;
    <a href="javascript:Popup('../Ferramentas/MiniConsulta/MiniConsulta.aspx?Tabela=T_Armazenamento&ColCod=Arm_Codigo&ColDesc=Arm_Estoque');"><img src="../images2/mais.png" border="0"/></a>
    </td>
    <td><asp:TextBox ID="txtPeso" runat="server" Columns="15" placeholder="Ex. 300gr"></asp:TextBox></td>
    <td><asp:TextBox ID="txtPrecoUni" class="real" runat="server" Columns="15"></asp:TextBox></td>
    <td><asp:DropDownList ID="listTpSaida" runat="server" Width="120px"></asp:DropDownList></td>
  </tr>
  
  <tr>
    <td height="30" colspan="5">Observações:</td>
  </tr>
  <tr>
  <td height="37" colspan="5">
  <asp:TextBox ID="txtObservacao" runat="server" Columns="86" Rows="8" 
          TextMode="MultiLine"></asp:TextBox>
  </td>
  </tr>
</table>
         </fieldset>
         
         </br>
         
                 <fieldset>
                   <legend class="field">Botões de Ação</legend>
                   <table width="100%" border="0" cellpadding="0" cellspacing="5">
                     <tr>

                       <td> 
                       <asp:Button class='button_form' ID="btnGravar" runat="server" Text="Gravar" onclick="btnGravar_Click" OnClientClick="return validarProduto()" />
                       <asp:Button class='button_form' ID="btnAlterar" runat="server" Text="Alterar" onclick="btnAlterar_Click" OnClientClick="return validarProduto()" /> 
                       <asp:Button class='button_form' ID="btnExcluir" runat="server" Text="Excluir" onclick="btnExcluir_Click" OnClientClick="return confirm('Tem certeza disso?')"/>
                       <asp:Button class='button_form' ID="btnLimpar" runat="server" Text="Limpar" onclick="btnLimpar_Click" />
                       </td>
                       
                       <td width="97"> 
                       <asp:Button class='button_form' ID="btnAjuda" runat="server" Text="Help" onclick="btnAjuda_Click" />
                       </td>

                     </tr>
                   </table>
         </fieldset>
                 <p></p>
               </div>
     </form>

</body>
</html>

