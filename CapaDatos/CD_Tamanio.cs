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
    public class CD_Tamanio
    {
        public List<TamanioBebida> Listar()
        {
            List<TamanioBebida> lista = new List<TamanioBebida>();
            // usamos cadena de conexion, declaramos como "objeto" la conexion (oconexion) como nuevo conector de sql (usamos "conexion.cadena" <- cadena: evento creado en "Conexion.cs" para unir con bd)
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    // Trae consulta
                    StringBuilder query = new StringBuilder();
                    // AppendLine: Permite dar salto de línea
                    query.AppendLine("SELECT TamanioID, Tamanio, Envase, EstadoBebida FROM TamanioBebida");
                    // comando sql llamado "cmd" nuevo comando sql pide: axion de la ejecucion (query)
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.Text;
                    //abre la conexion
                    oconexion.Open();
                    // utilizamos "using" para poder ejecutar el encargado de leer resultados de nuestros comandos "SqlDataReader" variable "dr" <- almacena comando "cmd"
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //mientras lee los resultados de los registros, necesitamos almacenar en la "lista de Categoria"
                        while (dr.Read())
                        {
                            //Agregar a la lista, un nuevo Categoria
                            lista.Add(new TamanioBebida()
                            {
                                //Empezamos a declarar la tabla de la Base de Datos, convirtiendo en entero32 el "CategoriaID"
                                // dr = variable donde se almacena la query, es decir, la consulta realizada (select)
                                TamanioID = Convert.ToInt32(dr["TamanioID"]),
                                Tamanio = dr["Tamanio"].ToString(),
                                Envase = dr["Envase"].ToString(),
                                EstadoBebida = Convert.ToBoolean(dr["EstadoBebida"]),
                            });
                        }
                    }

                }
                // si hay un error, muestra una lista sin elementos (como nueva)
                catch (Exception ex)
                {
                    lista = new List<TamanioBebida>();
                }
            }
            return lista;
        }
        // Registrar
        public int Registrar(TamanioBebida obj, out string Mensaje)
        {
            int CategoriaIDGenerada = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "RegistrarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARTAMANIOBEBIDA", oconexion);
                    cmd.Parameters.AddWithValue("Tamanio", obj.Tamanio);
                    cmd.Parameters.AddWithValue("Envase", obj.Envase);
                    cmd.Parameters.AddWithValue("EstadoBebida", obj.EstadoBebida);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.StoredProcedure;
                    //abre la conexion
                    oconexion.Open();

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    //obtener valores de salida
                    CategoriaIDGenerada = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CategoriaIDGenerada = 0;
                Mensaje = ex.Message;
            }

            return CategoriaIDGenerada;
        }


        // Editar
        public bool Editar(TamanioBebida obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EditarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_EDITARTAMANIOBEBIDA", oconexion);
                    cmd.Parameters.AddWithValue("Tamanio", obj.Tamanio);
                    cmd.Parameters.AddWithValue("Envase", obj.Envase);
                    cmd.Parameters.AddWithValue("EstadoBebida", obj.EstadoBebida);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.StoredProcedure;
                    //abre la conexion
                    oconexion.Open();

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    //obtener valores de salida
                    Resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
                Mensaje = ex.Message;
            }

            return Resultado;
        }


        // ELIMINAR 
        public bool Eliminar(TamanioBebida obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EliminarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARTAMANIOBEBIDA", oconexion);
                    cmd.Parameters.AddWithValue("TamanioID", obj.TamanioID);
                    cmd.Parameters.AddWithValue("EstadoBebida", obj.EstadoBebida);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    //Se le informa que el tipo de comando utilizado, es de texto
                    cmd.CommandType = CommandType.StoredProcedure;
                    //abre la conexion
                    oconexion.Open();

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    //obtener valores de salida
                    Resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
                Mensaje = ex.Message;
            }
            return Resultado;
        }
    }
}
