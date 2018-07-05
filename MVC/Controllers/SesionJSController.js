var SesionJSController = function ($scope) {
    
    $scope.fecha = Servicios.saludoSvc.getFecha();
    $scope.hora = Servicios.saludoSvc.getHora();
}

SesionJSController.$inject = ['$scope'];