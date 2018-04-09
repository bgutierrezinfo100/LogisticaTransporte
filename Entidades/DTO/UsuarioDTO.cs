using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DTO
{
    public class UsuarioDTO
    {
        public UsuarioDTO()
        {
            ID = 0;
            ID_Tipo = "";
            Usuario = "";
            Password = "";
            ID_Empresa = "";
            Fecha_Alta = DateTime.Now;
            Fecha_Baja = DateTime.Now;
            Activo = true;
        }

        public int ID { get; set; }
        public string ID_Tipo { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string ID_Empresa { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public DateTime Fecha_Baja { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
    }
}
