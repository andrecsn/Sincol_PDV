<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta_Cliente.aspx.cs" Inherits="Projeto.Ferramentas.MiniConsulta.Consulta_Cliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       
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


     <%--<script language="javascript"> window.resizeTo(300, 200)</script>--%>

<script type="text/javascript">
    var oMyObject = window.dialogArguments;
    var Texto = oMyObject.Texto;

    function Abre() {
        form1.Texto.value = Texto;
    }

    function OK() {
        var vReturnValue = new Object();
       // vReturnValue.Texto = document.getElementById("Texto").value;
       
        window.returnValue = vReturnValue;
        window.close();
    }
    </script>

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
<body onload="Abre();">
    <form id="form1" runat="server">
    <div>
      <table width="580">
          <tr>
            <td width="374" class="style2">Descrição:</td>
                <td width="194" class="style2">CPF: </td>
        </tr>
            <tr>
              <td height="39" class="style1"><asp:TextBox ID="txtCodigo" runat="server" Visible="false" Width="29px"></asp:TextBox>
                  <asp:TextBox ID="txtNome" AutoPostBack="true" runat="server" Visible="true" Columns="30" 
                    OnTextChanged="txtNome_TextChanged" ></asp:TextBox>
                      </td>
              <td class="style1"><asp:TextBox ID="txtCPF" runat="server" Visible="true" Columns="20"></asp:TextBox></td>
            </tr>
            <tr>
              <td class="style1" colspan="2"><div class="separacao"></div></td>
            </tr>
            <tr>
              <td class="style1" colspan="2">&nbsp;</td>
            </tr>
            <tr>
              <td class="style1" colspan="2">
                  <asp:GridView ID="GridView1" runat="server" 
                        CellPadding="4" ForeColor="Black" EmptyDataText="Nenhum Valor Retornado !"
                        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                        BorderStyle="None" BorderWidth="1px"  
                        Width="100%">
                        <Columns>
                          <asp:BoundField DataField="CLIE_NOME" HeaderText="Nome" />
                          <asp:BoundField DataField="CLIE_TELEFONE" HeaderText="Telefone" />
                          <asp:BoundField DataField="CLIE_CPF" HeaderText="CPF" />
                          <asp:BoundField DataField="CLIE_CNPJ" HeaderText="CNPJ" />
                       </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#999999" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                  </td>
            </tr>
            </table>
        
        
    </div>
    </form>
</body>
</html>