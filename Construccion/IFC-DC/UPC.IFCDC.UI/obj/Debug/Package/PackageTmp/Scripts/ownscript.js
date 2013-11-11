var actual = "#logros";
var actual2 = "#informesFinCiclo";

//$('document').ready(function () {
//    setDefaultComboBox();
//});

function llamarpopupNuevaAcciondeMejora(idLlamar, codigo, id) {
    popup(idLlamar);
    document.getElementById('codigoHallazgoAC').value = codigo;
    document.getElementById('hiddenAC').value = id;
    document.getElementById('ctl00_Contenido_hiddenAC2').value = id;

}
//--------------------------
function llamarpopupEditarHallazgo(idLlamar, texto, id) {
    popup(idLlamar);
    document.getElementById('ctl00_Contenido_popup_textoDescripcionHallazgoEditar').innerHTML = texto;

    document.getElementById('hiddenAE').value = id;
    document.getElementById('ctl00_Contenido_hiddenAE2').value = id;
}
function llammarpopupEditarAcciondeMejora(idLlamar, codigo, texto, id) {
    popup(idLlamar);
    document.getElementById('ctl00_Contenido_pCodigoHallazgoEditar').value = codigo;
    document.getElementById('ctl00_Contenido_popup_textoDescripcionAccionMejoraEditar').innerHTML = texto;
    document.getElementById('hiddenEAC').value = id;
    document.getElementById('ctl00_Contenido_hiddenEAC2').value = id;

}
//--------------------------
function change_view(show) {
    if (show !== actual) {
        $(actual).hide();
        $(show).fadeIn(300);    
        actual = show;
    }
}
//--------------------------
function change_view2(show) {
    if (show !== actual2) {
        $(actual2).hide();
        $(show).fadeIn(300);
        actual2 = show;
    }
}
//--------------------------
function popup(idpopup) {
    $(".dark-side").show();
    $(idpopup).show(500);
}
//--------------------------
function close_popup(idpopup) {
    $(idpopup).fadeOut(500);
    $(".dark-side").fadeOut(500);

}
//-------------------------------
function setDefaultComboBox() {

    $("select").each(function () {
        $(this).each(function () {
            if ($(this).val == "IMPLEMENTADO") {
                $(this).attr('selected', 'selected');
            }
        })


    });
   
}