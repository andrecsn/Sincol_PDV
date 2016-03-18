<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Página de Login - SINCOL</title>


<!--Estilos de Login-->
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.2/jquery.min.js"></script>
    <script src="css/estilo_login/js/jquery.tools.js" type="text/javascript"></script>
    <script src="css/estilo_login/js/jquery.uniform.min.js" type="text/javascript"></script>
    <script src="css/estilo_login/js/main.js" type="text/javascript"></script>

    <link href="css/estilo_login/css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/estilo_login/css/uniform.css" rel="stylesheet" type="text/css" />
<!--FIM Estilos de Login-->
   

<style type="text/css">
*{
    margin:0;
    padding:0;
}
body {
	background-color: #333;
}
a:link {
	color: #FFF;
}
a:hover {
	color: #0F0;
}
a {
	font-family: Verdana, Geneva, sans-serif;
	font-size: 12px;
}
a:visited {
	color: #FFF;
}
a:active {
	color: #0F0;
}   
.corpo {
	height: 500px;
	width: 450px;
	margin-top: 30px;
	margin-right: auto;
	margin-bottom: 0px;
	margin-left: auto;
}
.logo {
	height: 250px;
	width: 450px;
	float: left;
	margin-bottom:20px;
	background-image: url('../images2/logo_negativa.png');
    background-repeat: no-repeat;
    background-position: center;
}
.login {
	float: left;
	height: 220px;
	width: 370px;
	border-radius:10px;
	background-color: rgba(0, 0, 0, 0.3);
	font-family: Verdana, Geneva, sans-serif;
	font-size: 13px;
	color: #FFF;
	font-weight: bold;
	margin-left: 23px;
	padding: 15px;
}
.rodape {
	height: 50px;
	width: 400px;
	text-align: center;
	float: left;
	padding-top: 25px;
	font-family: Verdana, Geneva, sans-serif;
	font-size: 12px;
	color: #CCC;
}
    .style2
    {
    }
    .style3
    {
        width: 64px;
    }
</style>


</head>
<body>


<div class="corpo">
  <div class="logo">
  </div>

  <div class="login">

<form id="Form1" class="TTWForm" method="post" novalidate
  runat="server"  style=" width: 100%;">

<asp:Login ID="Login1" name="login1" runat="server" OnAuthenticate="Login1_Authenticate"  
    PasswordLabelText="Senha:" PasswordRequiredErrorMessage="Informe a senha." 
    RememberMeText="Lembrar Senha" UserNameLabelText="Usuário:" 
    UserNameRequiredErrorMessage="Informe o usuário" Width="369px">
    <LayoutTemplate>
        <table cellpadding="1" cellspacing="0" 
            style="border-collapse:collapse; width: 99%">
            <tr>
                <td>
                    <table cellpadding="0" style="width: 357px">
                        <tr>
                            <td align="left" class="style2" colspan="2">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Entre com o seu Usuário:</asp:Label></td>
                        </tr>
                        <tr>
                            <td align="left" class="style2" colspan="2">
                                
                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                    ControlToValidate="UserName" ErrorMessage="Informe o usuário" 
                                    ToolTip="Informe o usuário" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="style2" colspan="2">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Entre com sua Senha:</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="style2" colspan="2">
                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                    ControlToValidate="Password" ErrorMessage="Informe a senha." 
                                    ToolTip="Informe a senha." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:CheckBox ID="RememberMe" runat="server" Text="Lembrar Senha" />
                            </td>
                            <td class="style3">
                            <div id="form-submit" class="field f_100 clearfix submit">
                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Entrar" ValidationGroup="Login1" />
                                    </div>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="color:Red;" class="style2">
                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                            </td>
                            <td align="center" class="style3" style="color:Red;">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right" class="style2">
                            
                            </td>
                            <td align="right" class="style3">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </LayoutTemplate>
</asp:Login>
    
    </form>
  </div>

  <div class="rodape">Copyright © 2012. All Rights Reserved. <br />
Desenvolvido por <a href="#" target="_new">Equipe SINCOL</a></div>

</div>

</body>
</html>
