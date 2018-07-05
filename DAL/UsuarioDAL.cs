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
        public List<UsuarioDTO> loadListUsuario()
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
        public UsuarioDTO loadUsuario(int ID)
        {
            try
            {
                using (BD_LogisticaTransporteEntities BD = new BD_LogisticaTransporteEntities())
                {
                    var ModeloUsuario = BD.Usuarios.First(c => c.ID_Usuario == ID);

                    UsuarioDTO oUsuario = new UsuarioDTO();

                    oUsuario.Activo = bool.Parse(ModeloUsuario.Activo.ToString());
                    oUsuario.Usuario = ModeloUsuario.Nombre;
                    oUsuario.Password = ModeloUsuario.Nombre;

                    return oUsuario;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
