using Entidades.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;

namespace BAL
{
    public class UsuarioBAL : WorkUnit
    {
        private UsuarioDAL UsuDAL;
        public UsuarioBAL(BD_LogisticaTransporteEntities _logisticaBD) : base(_logisticaBD)
        {

        }
        public UsuarioBAL()
        {

        }
        public List<UsuarioDTO> GetUsuarios()
        {
            return UsuDAL.LoadListUsuario();
        }
        public UsuarioDTO GetUsuario(int ID)
        {
            return UsuDAL.LoadUsuario(ID);
        }
    }
}
