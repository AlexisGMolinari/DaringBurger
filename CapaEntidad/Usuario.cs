using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Representamos la Tabla "Usuario" de la base de datos, para que se pueda dar un inicio con su cuenta

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Clave { get; set; }
        public Rol oRol { get; set; } // Representacion a la columna IdRol de la base de datos "o" representa a Objeto
        public bool Estado { get; set; }
        public string FechaCreacion { get; set; }
    }
}
