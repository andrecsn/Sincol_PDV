<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="saida.aspx.cs" Inherits="Projeto.Operacoes.saida" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!--Estilos de Formulário-->
	<link rel="stylesheet" href="../css/estilos_formulario/jqtransform.css" type="text/css" media="all" />
	<link rel="stylesheet" href="../css/estilos_formulario/css/estilo.css" type="text/css" />
    <script type="text/javascript" src="../css/estilos_formulario/js/jquery.js" ></script>
	<script type="text/javascript" src="../css/estilos_formulario/jquery.jqtransform.js" ></script>
    <script type="text/javascript" src="../Ferramentas/Uteis.js" ></script>
    <!--CSS da AbaExpansiva-->
    <link rel="stylesheet" href="../Ferramentas/AbaExpansiva/css/style.css" />
    

	<script language="javascript">

	    $(document).ready(function () {
	        $('form').jqTransform({ imgPath: 'jqtransformplugin/img/' });
	    });


	    function modo_pagamento() {

	        var valor2 = form1.txtValor2.value;
	        var valor3 = form1.txtValor3.value;
	        var parcela = form1.listQuantidadeParcelas2.value;

	        var modo_pagamento = form1.listModoPagamento2.value;

	        if (modo_pagamento == "A Vista") {

	            document.getElementById("listQuantidadeParcelas2").value = "1";
	            document.getElementById("txtValor2").disabled = false;
	            document.getElementById("listQuantidadeParcelas2").disabled = true;


	            if (Valor3 == 0) {
	                document.getElementById("TxtValor2").disabled = true;
	            }

	        }
	        else if (modo_pagamento == "Parcelado") {
	            document.getElementById("listQuantidadeParcelas2").disabled = false;
	            document.getElementById("txtValor2").disabled = true;

	            var resultado = (valor3 / parcela);
	            resultado = resultado.toFixed(2);
	            form1.txtValor2.value = resultado;

	        }
	    }

	    function parcelas() {
	        var valor3 = form1.txtValor3.value;
	        var parcela = form1.listQuantidadeParcelas2.value;

	        document.getElementById("listQuantidadeParcelas2").disabled = false;

	        var resultado = (valor3 / parcela);
	        resultado = resultado.toFixed(2);
	        form1.txtValor2.value = resultado;
	    }
    </script>


    <!--FIM Estilos de Formulário-->


<script>
    // Login Form

    $(function () {
        var button = $('.loginButton');
        var box = $('.loginBox');
        var form = $('.loginForm');

        var button2 = $('.loginButton2');
        var box2 = $('.loginBox2');
        var form2 = $('.loginForm2');

        box.hide();
        box2.hide();

        button.removeAttr('href');
        button2.removeAttr('href');

        button.mouseup(function (login) {
            box.toggle();
            button.toggleClass('active');
        });

        button2.mouseup(function (login) {
            box2.toggle();
            button2.toggleClass('active');
        });

        form.mouseup(function () {
            return false;
        });

        form2.mouseup(function () {
            return false;
        });

        $(this).mouseup(function (login) {
            if (!($(login.target).parent('.loginButton').length > 0)) {
                button.removeClass('active');
                box.hide();
            }
        });

        $(this).mouseup(function (login) {
            if (!($(login.target).parent('.loginButton2').length > 0)) {
                button2.removeClass('active');
                box2.hide();
            }
        });

    });
</script>

<script language=javascript>
    function ConfirmaExclusao() {
        return confirm('Deseja realmente excluir este registro?');
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
.tamanho{ width: 210px;}
        .style1
        {
            width: 131px;
        }
        
.btexcluir
{
    height: 20px;
    width: 20px;
    background-image: url('../images2/deletar.png');
    background-repeat:no-repeat;
    background-position:center;
    margin-left: 5px;
    text-decoration:none;
}
.cupon_fiscal
{
    width:460px;
    height: 350px;
    border: thin solid #CCC;
}
    </style>

</head>
<body>


     <form id="form1" runat="server">
       <div class="corpo">


           <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>


           
<!-- OUTRAS FORMAS DE PAGAMENTO -->
		<div class="container2">
            <div class="loginContainer">
                <a href="#" class="loginButton2"><span>Pagamento</span><em></em></a>
                <div style="clear:both"></div>
                <div class="loginBox2">                
                    <div class="loginForm2">
                        <fieldset class="body">

                        

                          <table width="527" height="144" border="0" cellpadding="0" cellspacing="5">
                            <tr>
                              <td width="152" height="26">Modo de Pagamento:</td>
                              <td class="style1">Vencimento:</td>
                              <td width="102">Parcelas:</td>
                              <td width="117">Valor:</td>
                            </tr>
                            <tr>
                              <td height="31">
                        
                                  

                              <asp:DropDownList ID="listModoPagamento2" name="listModoPagamento2" runat="server" onchange="modo_pagamento()">
                                <asp:ListItem>A Vista</asp:ListItem>
                                <asp:ListItem>Parcelado</asp:ListItem>
                              </asp:DropDownList></td>
                              <td class="style1"><asp:TextBox ID="txtDataVencimento" name="txtDataVencimento" runat="server" Columns="10" 
                                      Enabled="False"></asp:TextBox></td>
                              <td><asp:DropDownList ID="listQuantidadeParcelas2" name="listQuantidadeParcelas2" runat="server" onchange="parcelas()"
                                AutoPostBack="False">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                              </asp:DropDownList></td>
                              <td><asp:TextBox ID="txtValor2" name="txtValor2" runat="server" Columns="10">0</asp:TextBox></td>
                            </tr>
                            <tr>
                              <td height="40" colspan="3"><div class="separacao"></div></td>
                              <td align="center"><asp:Button class='button_form' ID="btnIncluir" runat="server" Text="Incluir" OnClick="btnIncluir_Click" /></td>
                            </tr>
                            <tr>
                              <td height="40" colspan="4">
                            
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>

                            <asp:TextBox ID="txtValor3" runat="server" Columns="4">500</asp:TextBox>

                            <asp:GridView ID="GridView2" runat="server" BackColor="White" 
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="6" 
                               ForeColor="Black" Width="100%" EmptyDataText="Nenhuma forma de pagamento !"
                               onrowdeleting="ClienteGridView_RowDeleting" >
                                <Columns>
                                <asp:TemplateField>

                                <ItemTemplate>

                                   <asp:Button ID="btnExcluir" runat="server" Text="" CommandName="Delete"
                                   OnClientClick="javascript:return ConfirmaExclusao();" ToolTip="Excluir" CssClass="btexcluir" />
                               
                                </ItemTemplate>

                                </asp:TemplateField>
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
                                <asp:AsyncPostBackTrigger ControlID="btnIncluir" EventName="Click" />
                            </Triggers>
                           </asp:UpdatePanel>
                            
                                </td>
                            </tr>
                          </table>

                        </fieldset>
                        <span><a href="#">Outras formas de pagamento</a></span>

                    </div>
                </div>
            </div>
        </div>


<!-- DADOS DO PEDIDO -->
       <div class="container">
            
            <div class="loginContainer2">
                <a href="#" class="loginButton"><span>Pedido</span><em></em></a>
                <div style="clear:both"></div>
                <div class="loginBox">                
                    <div class="loginForm">
                        <fieldset class="body">
                            <table width="272" height="131" border="0" cellpadding="0" cellspacing="5">
          <tr>
            <td>Codigo:</td>
            <td>
                <asp:TextBox ID="txtCod" runat="server" Columns="14"></asp:TextBox></td>
          </tr>
          <tr>
            <td>Data de Venda:</td>
            <td>
                <asp:TextBox ID="txtDataVenda" runat="server" Columns="14" Enabled="False" 
                    EnableTheming="True"></asp:TextBox></td>
          </tr>
          <tr>
            <td>Estoque:</td>
            <td>
                <asp:TextBox ID="txtEstoque" runat="server" Columns="14"></asp:TextBox></td>
          </tr>
          <tr>
            <td>Vendedor:</td>
            <td>
                <asp:TextBox ID="txtVendedor" runat="server" Columns="14"></asp:TextBox></td>
          </tr>
        </table>
                        </fieldset>
                        <span><a href="#">Dados do Pedido</a></span>

                    </div>
                </div>
            </div>
        </div>


         <fieldset>
   <legend class="field">Saida de Produtos</legend>
   
            <table width="100%" height="491" border="0" cellpadding="0" cellspacing="5">
              <tr>
                <td height="30">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
              </tr>
              <tr>
                <td width="7%" height="28">Cliente:</td>
                <td colspan="3"><span class="style8">
                <asp:TextBox ID="txtCliNome" runat="server" Columns="37"></asp:TextBox></span> &nbsp;&nbsp;&nbsp; 
                <a href="javascript:Cliente('../Ferramentas/MiniConsulta/Consulta_Cliente.aspx');"><img src="../images2/search.png" border="0"/></a>
                </td>
              </tr>
              <tr>
                <td height="16" colspan="4"><div class="separacao"></div></td>
              </tr>
              <tr>
                <td height="25" colspan="3">Produto:</td>
                <td width="55%">&nbsp;</td>
              </tr>
              <tr>
                <td height="33" colspan="3"><asp:TextBox ID="txtprodNome" runat="server" Columns="23"></asp:TextBox></td>
                <td rowspan="5" align="center" valign="top">
                    <div class="cupon_fiscal"><iframe frameborder="0" width="460" height="350" scrolling="yes" id="cupon_fiscal" src="cupon.html"></iframe></div>
                    <%--<asp:Image ID="Image1" runat="server" Height="350px" Width="461px" />--%>
                  </td>
              </tr>
              <tr>
                <td height="31">QTD:                  </td>
                <td colspan="2"><asp:TextBox ID="txtQuantidadeItens" runat="server" Columns="17"></asp:TextBox></td>
              </tr>
              <tr>
                <td height="41">Valor:</td>
                <td width="20%"><asp:TextBox ID="txtValor" runat="server" Columns="8"></asp:TextBox></td>
                <td width="18%"><asp:Button class='button_form' ID="btnOK" runat="server" Text="OK" /></td>
              </tr>
              <tr>
                <td height="26" colspan="3"><div class="separacao"></div></td>
              </tr>
              <tr>
                <td colspan="3" rowspan="3" valign="top">
                
                <fieldset class="tamanho">
   				<legend class="field">Forma de Pagamento                  </legend>
   				<table width="185" border="0" cellpadding="0" cellspacing="5">
                  <tr>
                        <td height="40">Modo:</td>
                        <td><asp:DropDownList ID="listModoPagamento" runat="server" AutoPostBack="True">
                          <asp:ListItem>A Vista</asp:ListItem>
                          <asp:ListItem>Parcelado</asp:ListItem>
                        </asp:DropDownList></td>
                  </tr>
                      <tr>
                        <td>Parcelas:</td>
                        <td><asp:DropDownList ID="listQuantidadeParcelas" runat="server" 
                                AutoPostBack="True">
                          <asp:ListItem>1 X</asp:ListItem>
                          <asp:ListItem>2 X</asp:ListItem>
                          <asp:ListItem>3 X</asp:ListItem>
                          <asp:ListItem>4 X</asp:ListItem>
                          <asp:ListItem>5 X</asp:ListItem>
                          <asp:ListItem>6 X</asp:ListItem>
                        </asp:DropDownList></td>
                      </tr>
                      <tr>
                        <td height="46" colspan="2">
                            
                            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                               BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                               ForeColor="Black" Width="100%"
                                DataKeyNames="QUANT,VALOR" AutoGenerateColumns="False" >
                               <Columns>
                            <asp:CommandField ButtonType="image" SelectImageUrl="~/images2/arrow.png" ShowSelectButton="True">
                            <ControlStyle CssClass="button" />
                            </asp:CommandField>
                            <asp:BoundField DataField="QUANT" HeaderText="Quant" 
                                SortExpression="QUANT" >
                                   <FooterStyle HorizontalAlign="Center" />
                                   <HeaderStyle HorizontalAlign="Center" />
                                   </asp:BoundField>
                            <asp:BoundField DataField="VALOR" HeaderText="Valor" 
                                SortExpression="VALOR" />
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
                
                </td>
              </tr>
              <tr>
                <td height="16"><div class="separacao"></div></td>
              </tr>
              <tr>
                <td height="34"><table width="100%" border="0" cellpadding="0" cellspacing="5">
                  <tr>
                    <td width="61%" height="24" align="right">Total: </td>
                    <td width="61%"><asp:TextBox ID="txtTotal" runat="server" Columns="11"></asp:TextBox></td>
                    <td width="39%" align="right"><asp:Button class='button_form' ID="btnGravar" runat="server" Text="Finalizar" /></td>
                  </tr>
                </table></td>
              </tr>
            </table>
         </fieldset>

                  </br>
               </div>
     </form>

</body>
</html>
