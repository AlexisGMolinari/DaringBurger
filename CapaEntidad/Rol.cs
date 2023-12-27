using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Representamos la Tabla "ROL" de la base de datos, para que se pueda dar un inicio con su cuenta

    public class Rol
    {
        public int IdRol { get; set; }
        public string Descripcion { get; set; }
        public string FechaCreacion { get; set; }
    }
}
