using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Referencias para poder utilizar el evento listar
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();
            // usamos cadena de conexion, declaramos como "objeto" la conexion (oconexion) como nuevo conector de sql (usamos "conexion.cadena" <- cadena: evento creado en "Conexion.cs" para unir con bd
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol, p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @IdUsuario");


                    
                    // comando sql llamado "cmd" nuevo comando sql pide: axion de la ejecucion (query)
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", idusuario);
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
                            lista.Add(new Permiso()
                            {
                                //Empezamos a declarar la tabla de la Base de Datos, convirtiendo en entero32 el "IdUsuario"
                                // dr = variable donde se almacena la query, es decir, la consulta realizada (select)
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                                
                            });
                        }
                    }

                }
                // si hay un error, muestra una lista sin elementos (como nueva)
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
