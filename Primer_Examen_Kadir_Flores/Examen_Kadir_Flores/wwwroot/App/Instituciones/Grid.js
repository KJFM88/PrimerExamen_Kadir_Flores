"use strict";
var GridInstitucion;
(function (GridInstitucion) {
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }
    function OnclickEliminar(id) {
        ComfirmAlert("¿ Desea eliminar el registro ?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Institucion/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    GridInstitucion.OnclickEliminar = OnclickEliminar;
    $("GridView").DataTable();
})(GridInstitucion || (GridInstitucion = {}));
//# sourceMappingURL=Grid.js.map