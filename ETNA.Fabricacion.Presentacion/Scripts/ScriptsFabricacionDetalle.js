$(document).ready(function () {
    $(".btn").button();
    $(".dialog").attr("style", "display:none");
});

function confirmar(obj) {
    $("#dialog-confirm").dialog({
        resizable: false,
        modal: true,
        width: 250,
        height: 150,
        show: { effect: "scale", duration: 200 },
        hide: { effect: "puff", duration: 200 },
        buttons: {
            "Aceptar": function () { __doPostBack(obj.name, ''); $(this).dialog("close"); },
            "Cancelar": function () { $(this).dialog("close"); }
        }
    });
    return false;
}

function alerta1() {

    $(function () {

        $("#dialog-alert").dialog({
            resizable: false,
            modal: true,
            width: 250,
            height: 150,
            show: { effect: "scale", duration: 200 },
            hide: { effect: "puff", duration: 200 },
            buttons: {
                "Aceptar": function () { location.href = "ListadoSolicitudProduccion.aspx?codigoEstado=1" },

            }
        });
        return false;

    }).dialog("open");

}


function alerta1_Aprobar() {

    $(function () {

        $("#dialog-alert").dialog({
            resizable: false,
            modal: true,
            width: 250,
            height: 150,
            show: { effect: "scale", duration: 200 },
            hide: { effect: "puff", duration: 200 },
            buttons: {
                "Aceptar": function () { location.href = "ListadoSolicitudProduccion.aspx?codigoEstado=3" },

            }
        });
        return false;

    }).dialog("open");

}


function alerta2() {

    $(function () {

        $("#dialog-rechazo").dialog({
            resizable: false,
            modal: true,
            width: 250,
            height: 150,
            show: { effect: "scale", duration: 200 },
            hide: { effect: "puff", duration: 200 },
            buttons: {
                "Aceptar": function () { $(this).dialog("close"); }
            }
        })

        return false;

    }).dialog("open");
}


function alerta3() {

    $(function () {

        $("#dialog-mensajerechazo").dialog({
            resizable: false,
            modal: true,
            width: 250,
            height: 150,
            show: { effect: "scale", duration: 200 },
            hide: { effect: "puff", duration: 200 },
            buttons: {
                "Aceptar": function () { location.href = "ListadoSolicitudProduccion.aspx?codigoEstado=1" }
            }
        })

        return false;

    }).dialog("open");
}

function forzarValidacion(obj) {



    $("#dialog-forzarValidacion").dialog({
        resizable: false,
        modal: true,
        width: 250,
        height: 150,
        show: { effect: "scale", duration: 200 },
        hide: { effect: "puff", duration: 200 },
        buttons: {
            "Aceptar": function () { __doPostBack(obj.name, ''); $(this).dialog("close"); },
            "Cancelar": function () { $(this).dialog("close"); }
        }
    });
    return false;


}

function Rechazar(obj) {
    $("#dialog-Rechazar").dialog({
        resizable: false,
        modal: true,
        width: 250,
        height: 150,
        show: { effect: "scale", duration: 200 },
        hide: { effect: "puff", duration: 200 },
        buttons: {
            "Aceptar": function () {
                $(this).dialog("close");
                $("#dialog-IngresoObservacion").dialog({
                    resizable: false,
                    modal: true,
                    width: 450,
                    height: 200,
                    show: { effect: "scale", duration: 200 },
                    hide: { effect: "puff", duration: 200 },
                    buttons: {
                        "Aceptar": function () {
                            var hdObservacion = document.getElementById("ContentPlaceHolder1_hdObservaciones")
                            var sObservaciones = document.getElementById("ContentPlaceHolder1_txtObservaciones");
                            hdObservacion.text = document.getElementById("ContentPlaceHolder1_txtObservaciones").innerText;

                            __doPostBack(obj.name, '');
                            $(this).dialog("close");
                        },
                        "Cancelar": function () { $(this).dialog("close"); }
                    }
                });              

            },
            "Cancelar": function () { $(this).dialog("close"); }
        }
    });
    return false;


}