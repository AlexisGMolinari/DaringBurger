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
                    StringBuilder query = new StringBuilder();
                    // AppendLine: Permite dar salto de línea
                    query.AppendLine("select u.IdUsuario, u.NombreCompleto, u.Clave, u.Estado, r.IdRol, r.Descripcion from usuario u");
                    query.AppendLine("inner join rol r on r.IdRol = u.IdRol");
                    // comando sql llamado "cmd" nuevo comando sql pide: axion de la ejecucion (query)
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
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
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() }
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
        // Registrar
        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "RegistrarUsuario"
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.StoredProcedure;
                    //abre la conexion
                    oconexion.Open();

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    //obtener valores de salida
                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }


        // Editar
        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EditarUsuario"
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.StoredProcedure;
                    //abre la conexion
                    oconexion.Open();

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    //obtener valores de salida
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }


        // ELIMINAR 
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EliminarUsuario"
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;

                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.StoredProcedure;
                    //abre la conexion
                    oconexion.Open();

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    //obtener valores de salida
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;
        }
    }
    
}


