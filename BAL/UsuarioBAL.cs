using Entidades.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class UsuarioBAL
    {
        UsuarioDAL dUsuarios = new UsuarioDAL();
        public List<UsuarioDTO> GetUsuarios()
        {
            return dUsuarios.loadListUsuario();
        }
        public UsuarioDTO GetUsuario(int ID)
        {
            return dUsuarios.loadUsuario(ID);
        }
    }
}
