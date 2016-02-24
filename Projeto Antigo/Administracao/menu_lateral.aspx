<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_lateral.aspx.cs" Inherits="Projeto.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Lateral</title>

    <link href="css/menu_lateral.css" rel="stylesheet" type="text/css" />

</head>

<body>

<style type="text/css">
    
body
{
    margin:10;
    padding:0;
}
.menu {
	height: 30px;
	width: 213px;
	font-family: Verdana, Geneva, sans-serif;
	font-size: 14px;
	color: #333;
	padding-top: 10px;
	padding-right: 7px;
	padding-bottom: 0px;
	padding-left: 7px;
	float: left;
}
a.menu:hover{
	font-family: Verdana, Geneva, sans-serif;
	font-size: 14px;
	color: #333;
	font-weight: bold;
	height: 30px;
	display: block;
	padding-left: 5px;
	border-left-width: 10px;
	border-left-style: solid;
	border-left-color: #333;
	background-color: rgba(51,51,51,0.2);
}
.caixa {
	height: 100%;
	width: 230px;
}
a:link {
	text-decoration: none;
	color: #333;
}
a:visited {
	text-decoration: none;
	color: #333;
}
a:hover {
	text-decoration: none;
	color: #333;
}
a:active {
	text-decoration: none;
	color: #333;
}
</style>
</head>

<body>

<div class="caixa">
<a class="menu" target='conteudo' href="Cadastros/produto.aspx">Principal</a>
<a class="menu" target='conteudo' href="Cadastros/produto_telas/consulta_principal.aspx">Consulta</a>
<a class="menu" target='conteudo' href="Cadastros/produto_telas/movimentacao.aspx">Movimentação</a>
<a class="menu" target='conteudo' href="Cadastros/produto_telas/estoque.aspx">Estoque</a>
<a class="menu" target='conteudo' href="Cadastros/produto_telas/tabela_preco.aspx">Tabela de Preço</a>
<a class="menu" target='conteudo' href="Cadastros/produto_telas/observacoes.aspx">Observações</a>
<a class="menu" target='conteudo' href="Cadastros/produto_telas/imagens_documentos.aspx">Imagens e Documentos</a>
</div>

</body>
</html>
