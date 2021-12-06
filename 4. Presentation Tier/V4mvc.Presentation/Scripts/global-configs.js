function CustomOnAjaxReqSend() {
    $('body').waitMe({
        effect: 'bounce',
        text: typeof CONSTANTES != 'undefined' && typeof CONSTANTES.WAIT_ME_MSG_LOADING != 'undefined' ? CONSTANTES.WAIT_ME_MSG_LOADING : '',
        bg: 'rgba(255, 255, 255, 0.7)',
        color: 'rgb(0, 0, 0)',
        maxSize: '',
        waitTime: -1,
        textPos: 'vertical',
        fontSize: '20px',
        source: '',
        onClose: function () { }
    });
}

function CustomOnAjaxReqComplete() {
    $('body').waitMe("hide");
}


$(document).ready(function () {
    $(document)
        .bind("ajaxSend", CustomOnAjaxReqSend)
        .bind("ajaxComplete", CustomOnAjaxReqComplete);
});