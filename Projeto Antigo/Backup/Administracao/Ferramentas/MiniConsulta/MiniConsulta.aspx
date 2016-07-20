<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MiniConsulta.aspx.cs" Inherits="Administracao.MnConsulta" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
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
	
    <style type="text/css">
        .style1
        {
            width: 374px;
        }
        .style2
        {
            width: 374px;
            height: 26px;
        }
        </style>


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

</head>
<body onload="Abre();">
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtTabela" runat="server" Visible="false" Width="29px"></asp:TextBox>
    <asp:TextBox ID="txtColCod" runat="server" Visible="false" Width="29px" ></asp:TextBox>
    <asp:TextBox ID="txtColDesc" runat="server" Visible="false" Width="29px"></asp:TextBox>

        <table style="width: 476px;">
            <tr>
                <td class="style2">
                    Descrição
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:TextBox ID="txtCodigo" runat="server" Visible="false" Width="29px"></asp:TextBox>
                    <asp:TextBox ID="txtDescricao" runat="server" Visible="true" Columns="44" autofocus></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Button class='button_form' ID="Button1" runat="server"  Text="Gravar" onclick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button class='button_form' ID="Button4" runat="server" Text="Excluir" 
                        onclick="Button4_Click" />
                &nbsp;&nbsp;&nbsp;
                    <asp:Button class='button_form' ID="Button2" runat="server" Text="Limpar" onclick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;                   
                   <input name="button" class='button_form' id="sair" type="button" value="Sair" onclick="OK();" ></td>
            </tr>
            <tr>
                <td class="style1">
                    <br />
                    <asp:GridView ID="GridView1" runat="server"  
                        CellPadding="4" ForeColor="Black"
                        OnRowCommand="GridView1_Command" DataKeyNames="CODIGO,DESCRICAO" 
                        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                        BorderStyle="None" BorderWidth="1px" 
                        Font-Names="Verdana,Arial" Width="453px"                         >
                        <Columns>
                            <asp:CommandField ButtonType="image" SelectImageUrl="~/images2/arrow.png" ShowSelectButton="True" 
                               >
                            <ControlStyle CssClass="button" />
                            </asp:CommandField>
                            <asp:BoundField DataField="CODIGO" HeaderText="Código" 
                                SortExpression="CODIGO" Visible="False" />
                            <asp:BoundField DataField="DESCRICAO" HeaderText="Descrição" 
                                SortExpression="DESCRICAO">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="400px" />
                            </asp:BoundField>
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
                    &nbsp;</td>
            </tr>
        </table>
        
        
    </div>
    </form>
</body>
</html>
