<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_rapido.aspx.cs" Inherits="Projeto.WebForm4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Rápido - SINCOL</title>

<script type="text/javascript" src="css/menu_rapido/jquery.js"></script>
<script type="text/javascript" src="css/menu_rapido/interface.js"></script>
<link href="css/menu_rapido/style.css" rel="stylesheet" type="text/css" media="screen">

<script type="text/javascript">
    $(document).ready(
	function () {
	    $('div.recebeDrag').Sortable(
			{
			    accept: 'itemDrag',
			    helperclass: 'dragAjuda',
			    activeclass: 'dragAtivo',
			    hoverclass: 'dragHover',
			    handle: 'h2',
			    opacity: 0.7,
			    onChange: function () {
			        serialEsq = $.SortSerialize('drop-esquerda');
			        serialDir = $.SortSerialize('drop-direita');
			        $('#ser-e').val(serialEsq.hash);
			        $('#ser-d').val(serialDir.hash);
			    },
			    onStart: function () {
			        $.iAutoscroller.start(this, document.getElementsByTagName('body'));
			    },
			    onStop: function () {
			        $.iAutoscroller.stop();
			    }
			}
		);
	}
);
</script>

<style>
body
{
    background-color: #FFFFFF;
}

</style>

</head>
<body>

<div id="drop-esquerda" class="recebeDrag">
  
<div id="blog" class="itemDrag" style="position: static; display: block; left: -242px; top: -107px;">
    <h2>FINANCEIRO</h2>
    <div class="menu_rapido_caixa">

        <a class="caixa_menu"  href="#">
        <img src="images2/financeiro.png" style="height: 90px; width: 90px ; border: 0"" /></a>

    </div>
  </div>
  
  
  <div id="debates" class="itemDrag" style="position: static; display: block; left: 606px; top: 519px;">
    <h2>CAD. DE CLIENTE</h2>
    
    <div class="menu_rapido_caixa">
    <a class="caixa_menu"  href="#">
        <img src="images2/cliente.png" style="height: 90px; width: 90px ; border: 0"" /></a>
        
</div></div>

  
  <div id="perfis" class="itemDrag" style="position: static; display: block; left: -504px; top: -3px;">
    <h2>RELATÓRIOS</h2>
    
    <div class="menu_rapido_caixa">
    <a class="caixa_menu"  href="#">
        <img src="images2/relatorio.png" 
         style="border-style: none; border-color: inherit; border-width: 0; height: 90px; width: 90px; "/></a>
</div></div>

<div id="blog" class="itemDrag" style="position: static; display: block; left: -242px; top: -107px;">
    <h2>CAD. FORNECEDOR</h2>
    <div class="menu_rapido_caixa">

        <a class="caixa_menu"  href="#">
        <img src="images2/fornecedor.png" 
            style="height: 90px; width: 90px ; border: 0"" /></a>

    </div>
  </div>

</div>


<!-- / box drop-esquerda -->
<div id="drop-direita" class="recebeDrag">
 
  <div id="aassinados" class="itemDrag" style="position: static; display: block; left: 658px; top: 181px;">
  	
    <h2>ESTOQUE</h2>
    
    <div class="menu_rapido_caixa">
    <a class="caixa_menu"  href="#">
        <img src="images2/estoque.png" style="height: 90px; width: 90px ; border: 0"" /></a>
        
  </div></div>
  
  <div id="aassinados" class="itemDrag" style="position: static; display: block; left: 658px; top: 181px;">
  	
    <h2>CAD. PRODUTO</h2>
    
    <div class="menu_rapido_caixa">
    <a class="caixa_menu"  href="#">
        <img src="images2/produto.png" style="height: 90px; width: 90px ; border: 0"" /></a>
        
  </div></div>


<div id="debates" class="itemDrag" style="position: static; display: block; left: 606px; top: 519px;">
    <h2>VENDA</h2>
    
    <div class="menu_rapido_caixa">
    <a class="caixa_menu"  href="#">
        <img src="images2/saida.png" style="height: 90px; width: 90px ; border: 0"" /></a>
        
</div></div>


  <div id="aassinados" class="itemDrag" style="position: static; display: block; left: 658px; top: 181px;">
  	
    <h2>ESTOQUE</h2>
    
    <div class="menu_rapido_caixa">
    <a class="caixa_menu"  href="#">
        <img src="images2/estoque.png" style="height: 90px; width: 90px ; border: 0"" /></a>
        
  </div></div>

</div>
<!-- / box drop-direita -->


</body>
</html>
