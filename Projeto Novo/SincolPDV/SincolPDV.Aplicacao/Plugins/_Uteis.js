
//Buttons

//Incluir Cliente
function Incluir(caminho, mensagem) {

    var cont = 0;
    $("#formDados .required").each(function () {
        if ($(this).val() == "") {
            $(this).css({ "border": "1px solid #F00" });
            cont++;
        }
    });

    if (cont == 0) {
        var dadosSerializados = $('#formDados').serialize();
        $.ajax({
            type: "POST",
            url: caminho,
            data: dadosSerializados,
            success: function () {
                $("#modal").modal('hide');
                MensagemSucesso(mensagem);
                GeraDataTableCliente();
            },
            error: function () {
                $("#modal").modal('hide');
                MensagemErro('Ocorreu um Erro ao Incluir!');
            }
        });
    } else {
        $('#formDados #mensagem').css("display", "block");
    }
}

//Editando Cliente
function Editar(caminho, mensagem) {

    var cont = 0;
    $("#formDados .required").each(function () {
        if ($(this).val() == "") {
            $(this).css({ "border": "1px solid #F00" });
            cont++;
        }
    });

    if (cont == 0) {
        var dadosSerializados = $('#formDados').serialize();
        $.ajax({
            type: "POST",
            url: caminho,
            data: dadosSerializados,
            success: function () {
                $("#modal").modal('hide');
                MensagemSucesso(mensagem);
                GeraDataTableCliente();
            },
            error: function () {
                $("#modal").modal('hide');
                MensagemErro('Ocorreu um Erro ao Editar!');
            }
        });
    } else {
        $('#formDados #mensagem').css("display", "block");
    }
}

//Deletando Cliente
function Deletar(caminho, mensagem) {
    var dadosSerializados = $('#formDados').serialize();
    $.ajax({
        type: "POST",
        url: caminho,
        data: dadosSerializados,
        success: function () {
            $("#modal").modal('hide');
            MensagemSucesso(mensagem);
            GeraDataTableCliente();
        },
        error: function () {
            $("#modal").modal('hide');
            MensagemErro('Ocorreu um erro ao Deletar!');
        }
    });
}


//Mensagens de Erro/Sucesso

function MensagemSucesso(mensagem) {
    $.toast({
        heading: 'Sucesso',
        text: mensagem,
        position: 'top-right',
        showHideTransition: 'slide',
        icon: 'success'
    })
}

function MensagemErro(mensagem) {
    $.toast({
        heading: 'Error',
        text: mensagem,
        position: 'top-right',
        showHideTransition: 'fade',
        icon: 'error'
    })
}


