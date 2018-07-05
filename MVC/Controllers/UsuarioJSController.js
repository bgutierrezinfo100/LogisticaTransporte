var UsuarioJSController = function ($scope) {
    var usuario =
	{
	    nombre: "iBrandonGtz",
	    contacto: {
	        movil: 5555555555,
	        correo: "gutierreztbrandonv13@hotmail.com",
	        telefono: 5555555555
	    }
	}

    $scope.usuario = usuario;
}

UsuarioJSController.$inject = ['$scope'];