function Popup(tela) {

    var aForm;
    aForm = form1.elements;
    var myObject = new Object();

    retorno = window.showModalDialog(tela, myObject, "dialogHeight:300px; dialogLeft:200px;");

}

function MsgBox(mensagem) {
    alert(mensagem);
}

/*DEFINIÇÃO DAS VALIDAÇÕES*/
jQuery(function ($) {
    /* mascara data */
    $('.data').mask('99/99/9999');
    /* mascara cpf */
    $('.cpf').mask('999.999.999-99');
    /* mascara cnpj */
    $('.cnpj').mask('99.999.999/9999-99');
    /* mascara placa */
    $('.placa').mask('aaa-9999');
    /* mascara telefone */
    $('.fone').mask('(99)9999-9999');
    /* mascara telefone */
    $('.cep').mask('99999-999');
    /*mascara hora*/
    $('.hora').mask('99:99');
    /*mascara dinheiro*/
    $('.real').maskMoney({ showSymbol: true, symbol: "R$", decimal: ",", thousands: "." });
});

//Validações

/*------------------------------VALIDAÇÃO DE CLIENTES-------------------------------*/

function validarCliente() {

    var codigo = form1.txtCodigo.value;
    var nome = form1.txtNome.value;
    var cpf = form1.txtCPF.value;
    var cnpj = form1.txtCNPJ.value;


    if (codigo == "") {
        alert('Preencha o campo Código!');
        form1.txtCodigo.focus();
        return false;
    }

    if (nome == "") {
        alert('Preencha o campo Nome do Cliente!');
        form1.txtNome.focus();
        return false;
    }

    if (cpf == "") {
        alert('Preencha o campo CPF!');
        form1.txtCPF.focus();
        return false;
    }

    if (cnpj == "") {
        alert('Preencha o campo CNPJ!');
        form1.txtCNPJ.focus();
        return false;
    }

}


/*------------------------------VALIDAÇÃO DE FORNECEDOR-------------------------------*/
function validarFornecedor() {

    var codigo = form1.txtCodigo.value;
    var nome = form1.txtNome.value;
    var cpf = form1.txtCPF.value;
    var cnpj = form1.txtCNPJ.value;
    var telefone = form1.txtTelefone.value;
    var endereco = form1.txtEndereco.value;


    if (codigo == "") {
        alert('Preencha o campo Código!');
        form1.txtCodigo.focus();
        return false;
    }

    if (nome == "") {
        alert('Preencha o campo Nome do Cliente!');
        form1.txtNome.focus();
        return false;
    }

    if (cpf == "") {
        alert('Preencha o campo CPF!');
        form1.txtCPF.focus();
        return false;
    }

    if (cnpj == "") {
        alert('Preencha o campo CNPJ!');
        form1.txtCNPJ.focus();
        return false;
    }

    if (telefone == "") {
        alert('Preencha o campo Telefone!');
        form1.txtTelefone.focus();
        return false;
    }

    if (endereco == "") {
        alert('Preencha o campo Endereço!');
        form1.txtEndereco.focus();
        return false;
    }

}


/*------------------------------VALIDAÇÃO DE PRODUTOS-------------------------------*/
function validarProduto() {

    var referencia = form1.txtReferencia.value;
    var descricao = form1.txtDescricao.value;
    var marca = form1.txtMarca.value;
    var EstoMinimo = form1.txtEstoMinimo.value;
    var EstoMaximo = form1.txtEstoMaximo.value;
    var PrecoUni = form1.txtPrecoUni.value;


    if (referencia == "") {
        alert('Preencha o campo Código!');
        form1.txtReferencia.focus();
        return false;
    }

    if (descricao == "") {
        alert('Preencha o campo descrição do produto!');
        form1.txtDescricao.focus();
        return false;
    }

    if (marca == "") {
        alert('Preencha a marca do produto!');
        form1.txtMarca.focus();
        return false;
    }

    if (EstoMinimo == "") {
        alert('Preencha o estoque minimo de produtos!');
        form1.txtEstoMinimo.focus();
        return false;
    }

    if (EstoMaximo == "") {
        alert('Preencha o estoque maximo de produtos!');
        form1.txtEstoMaximo.focus();
        return false;
    }

    if (PrecoUni == "") {
        alert('Preencha o preço do produto!');
        form1.txtPrecoUni.focus();
        return false;
    }

}
