using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DTO;

namespace DAL
{
    public class UsuarioDAL
    {
        public List<Entidades.DTO.UsuarioDTO> loadUsuario()
        {
            try
            {
                using (BD_LogisticaTransporteEntities BD = new BD_LogisticaTransporteEntities())
                {
                    List<UsuarioDTO> oUsuarios = BD.Usuarios.Include(c => c.Nombre).Select(c => new UsuarioDTO()
                    {
                        ID = c.ID_Usuario,
                        Usuario = c.Nombre,
                        Password = c.Pass,
                        ID_Tipo = c.ID_TipoUsuario
                    }).ToList();

                    return oUsuarios;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
