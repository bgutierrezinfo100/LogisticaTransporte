using Entidades.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    class UsuarioBAL
    {
        public List<UsuarioDTO> GetUsuarios()
        {
            UsuarioDAL dUsuarios = new UsuarioDAL();
            return dUsuarios.loadUsuario();
        }
    }
}
