
//Buttons
function ValidarCampos()
{
    var cont = 0;
    $("#formDados .required").each(function () {
        if ($(this).val() == "" || $(this).val() == "0") {
            $(this).css({ "border": "1px solid #F00" });
            $(this).addClass("Sim");
            cont++;
        }
    });

    $("#formDados .required.select2").each(function () {
        if ($(this).val() == "0") {
            $(this).parent().find(".select2-selection").css({ "border": "1px solid #F00" });
            //$(this).next().addClass("Sim");
            cont++;
        }
    });

    $("#formDados .Sim").each(function () {
        if ($(this).val() != "") {
            $(this).css({ "border": "1px solid #CCC" });
            $(this).removeClass("Sim");
        }
    });

    $("#formDados .required.select2").each(function () {
        if ($(this).val() != "0") {
            $(this).parent().find(".select2-selection").css({ "border": "1px solid #CCC" });
            //$(this).next().removeClass("Sim");
        }
    });

    return cont;
}

//Incluir
function Incluir(caminho, mensagem) {

    if (ValidarCampos() == 0) {
        var dadosSerializados = $('#formDados').serialize();
        $.ajax({
            type: "POST",
            url: "/NovoPdv" + caminho,
            data: dadosSerializados,
            success: function () {
                $("#modal").modal('hide');
                MensagemSucesso(mensagem);
                GeraDataTable();
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

//Editando
function Editar(caminho, mensagem) {

    if (ValidarCampos() == 0) {
        var dadosSerializados = $('#formDados').serialize();
        $.ajax({
            type: "POST",
            url: "/NovoPdv" + caminho,
            data: dadosSerializados,
            success: function () {
                $("#modal").modal('hide');
                MensagemSucesso(mensagem);
                //$("#box-widget").activateBox();
                GeraDataTable();
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

//Deletando
function Deletar(caminho, mensagem) {
    var dadosSerializados = $('#formDados').serialize();
    $.ajax({
        type: "POST",
        url: "/NovoPdv" + caminho,
        data: dadosSerializados,
        success: function () {
            $("#modal").modal('hide');
            MensagemSucesso(mensagem);
            GeraDataTable();
        },
        error: function () {
            $("#modal").modal('hide');
            MensagemErro('Ocorreu um erro ao Deletar!');
        }
    });
}

//============================================POPUP============================================

function IncluirPopUp(caminho, mensagem) {

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
            url: "/NovoPdv" + caminho,
            data: dadosSerializados,
            success: function () {
                MensagemSucesso(mensagem);
                GeraDataTablePopUp();
            },
            error: function () {
                MensagemErro('Ocorreu um Erro ao Incluir!');
            }
        });
    } else {
        $('#formDados #mensagem').css("display", "block");
    }
}

function DeletarModal(caminho, modal, mensagem) {
    var dadosSerializados = $('#formDados2').serialize();
    $.ajax({
        type: "POST",
        url: "/NovoPdv" + caminho,
        data: dadosSerializados,
        success: function () {
            $(modal).modal('hide');
            MensagemSucesso(mensagem);
            GeraDataTablePopUp();
        },
        error: function () {
            $(modal).modal('hide');
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


