search = function () {
    $.post('/Seccion/searchEmployee', {
        filter: $('#options').value(), // id del combox
        dateFilter: $('#information').value()     //id de caja de texto
    }, function (res) {
        $('#employeesTable').html(res) //id de la tabla
    }
    )



}