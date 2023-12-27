using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Representamos la Tabla "Permiso" de la base de datos, para que se pueda dar un inicio con su cuenta

    public class Permiso
    {
        public int IdPermiso { get; set; }
        public Rol oRol { get; set; } // Indicamos relacion de Rol con IdRol
        public string NombreMenu { get; set; }  
        public string FechaCreacion { get; set; }
    }
}
