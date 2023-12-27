using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Usuario
    {
        // A éste metodo lo debe de llamar la capa de Negocio (Entonces se crea clase dentro de negocio)
        public List<Usuario> Listar ()
        {
            List<Usuario> lista = new List<Usuario>();
            // usamos cadena de conexion, declaramos como "objeto" la conexion (oconexion) como nuevo conector de sql (usamos "conexion.cadena" <- cadena: evento creado en "Conexion.cs" para unir con bd
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    // Trae consulta
                    string query = "select IdUsuario, NombreCompleto, Clave, Estado from usuario";
                    // comando sql llamado "cmd" nuevo comando sql pide: axion de la ejecucion (query)
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.Text;
                    //abre la conexion
                    oconexion.Open();
                    // utilizamos "using" para poder ejecutar el encargado de leer resultados de nuestros comandos "SqlDataReader" variable "dr" <- almacena comando "cmd"
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //mientras lee los resultados de los registros, necesitamos almacenar en la "lista de usuario"
                        while (dr.Read())
                        {
                            //Agregar a la lista, un nuevo usuario
                            lista.Add(new Usuario()
                            {
                                //Empezamos a declarar la tabla de la Base de Datos, convirtiendo en entero32 el "IdUsuario"
                                // dr = variable donde se almacena la query, es decir, la consulta realizada (select)
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]), 
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            }) ;
                        }
                    }

                }
                // si hay un error, muestra una lista sin elementos (como nueva)
                catch (Exception ex) {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
        
    }
}
