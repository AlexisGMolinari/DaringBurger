using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class conexion
    {
        // Declaramos "cadena" como público, decimos que la coneccion se llame "cadena_conexion"
        public static string cadena = ConfigurationManager.ConnectionStrings["Cadena_conexion"].ToString();
    }
}
