var Servicios = function ($scope) {
    var saludoSvc = {};
    
    saludoSvc.getFecha = function ()
    {
        var meses = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'];

        //Obtenemos la fecha de hoy
        var fecha = new Date();

        //El mes a partir del objeto fecha
        var mes = fecha.getMonth();

        //Devolvemos un string que devoverá el día, el mes (en castellano) y el año
        return 'Hoy es ' + fecha.getDate() + ' de ' + meses[mes] + ' del ' + fecha.getFullYear();
    }

    //Esta funcion devolverá la hora
    saludoSvc.getHora = function ()
    {
        return new Date().toTimeString();
    }

    return saludoSvc;
}

Servicios.$inject = ['$scope'];