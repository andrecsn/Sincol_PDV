<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Página de Login - SINCOL</title>

<!--Estilos de Login-->
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.2/jquery.min.js"></script>
    <script src="estilo_login/js/jquery.tools.js" type="text/javascript"></script>
    <script src="estilo_login/js/jquery.uniform.min.js" type="text/javascript"></script>
    <script src="estilo_login/js/main.js" type="text/javascript"></script>

    <link href="estilo_login/css/style.css" rel="stylesheet" type="text/css" />
    <link href="estilo_login/css/uniform.css" rel="stylesheet" type="text/css" />
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
	width: 400px;
	margin-top: 30px;
	margin-right: auto;
	margin-bottom: 0px;
	margin-left: auto;
}
.logo {
	height: 200px;
	width: 400px;
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
	padding: 15px;
}
<!--.rodape {
	height: 50px;
	width: 400px;
	text-align: center;
	float: left;
	padding-top: 25px;
	font-family: Verdana, Geneva, sans-serif;
	font-size: 12px;
	color: #CCC;
}
/*
.rodape2 {
	height: 196px;
	width: 100%;
	position: absolute;
	bottom: 0;
	background-image: url('../images2/predios.png');
	background-repeat: no-repeat;
	background-position: center;
	z-index: 1;
	margin-bottom: 20px;
}
.rodape3 {
	height: 40px;
	width: 100%;
	position: absolute;
	bottom: 0;
	z-index: 2;
	background-color: #FFF;
	background-color: rgba(0, 0, 0, 0.4);
}
*/
        .style1
        {
            width: 207px;
        }
    </style>
</head>
<body>


<div class="corpo">
  <div class="logo">
  </div>

  <div class="login">

<form action="#" class="TTWForm" method="post" novalidate
    style=" width: 100%; height: 100%">

    <table width="360px" height="187" border="0" cellpadding="0" cellspacing="5">
      <tr>
        <td width="51%" colspan="2" style="width: 100%">Entre com o seu Usuário:</td>
      </tr>
      <tr>
        <td colspan="2"><label for="login"></label>
          <input name="login" type="text" id="login" /></td>
        </tr>
      <tr>
        <td colspan="2">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="2">Entre com sua Senha:</td>
      </tr>
      <tr>
        <td colspan="2"><input name="senha" type="password" id="senha" /></td>
        </tr>
      <tr>
      <td class="style1">
      <a href="#">Esqueceu sua senha?</a>
      </td>
        <td>
        <div id="form-submit" class="field f_100 clearfix submit" 
           style="margin: 0px; padding: 0px; width: 103%; top: 0px;">
               <input value="Entrar" type="submit">
          </div>
        </td>
      </tr>
    </table>
    
    </form>
  </div>

  <div class="rodape">Copyright © 2012. All Rights Reserved. <br />
Desenvolvido por <a href="http://www.lithiumtecnologia.com.br" target="_new">Equipe SINCOL</a></div>

</div>

</body>
</html>
