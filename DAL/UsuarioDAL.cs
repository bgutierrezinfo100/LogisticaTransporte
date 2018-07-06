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
    public class UsuarioDAL: BD
    {
        public UsuarioDAL(BD_LogisticaTransporteEntities _logisticaBD) : base(_logisticaBD) { }

        public List<UsuarioDTO> LoadListUsuario()
        {
            try
            {

                List<UsuarioDTO> oUsuarios = LogisticaBD.Usuarios.Select(c => new UsuarioDTO()
                {
                    ID = c.ID_Usuario,
                    Usuario = c.Nombre,
                    Password = c.Pass,
                    ID_Tipo = c.ID_TipoUsuario
                }).ToList();

                return oUsuarios;
                
            }
            catch (Exception ex)
            { throw ex; }
        }
        public UsuarioDTO LoadUsuario(int ID)
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
