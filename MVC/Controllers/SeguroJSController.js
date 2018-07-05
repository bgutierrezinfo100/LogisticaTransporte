var SeguroJSController = function ($scope)
{
    $scope.seguro =
        {
            nif: "",
            nombre: "",
            ape1: "",
            edad: undefined,
            sexo: "",
            casado: true,
            numHijos: undefined,
            embarazada: true,
            coberturas: {
                oftalmologia: true,
                dental: true,
                fecundacionInVitro: true
            },
            enfermedades: {
                corazon: true,
                estomacal: true,
                rinyones: true,
                alergia: true,
                nombreAlergia: ""
            },
            fechaCreacion: new Date()
        }
}

SeguroJSController.$inject = ['$scope'];