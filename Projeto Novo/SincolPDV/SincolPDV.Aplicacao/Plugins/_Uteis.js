
//Buttons



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


