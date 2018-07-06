using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades.DTO;
using BAL;

namespace WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WSUsuarios : IWSUsuarios
    {
        UsuarioBAL UsuBAL = new UsuarioBAL();

        List<UsuarioDTO> IWSUsuarios.GetListUsuarios()
        {
            List<UsuarioDTO> Usuarios = new List<UsuarioDTO>();

            Usuarios = UsuBAL.GetUsuarios();
            return Usuarios;
        }

        public UsuarioDTO GetUsuario(int ID)
        {
            UsuarioDTO Usuario = new UsuarioDTO();

            Usuario = UsuBAL.GetUsuario(ID);
            return Usuario;
        }

    }
}
