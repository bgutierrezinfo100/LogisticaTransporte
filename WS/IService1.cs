using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSUsuarios
    {
        [OperationContract]
        Entidades.DTO.UsuarioDTO GetUsuario(int ID);

        [OperationContract]
        List<Entidades.DTO.UsuarioDTO> GetListUsuarios();

        // TODO: Add your service operations here
    }
}
