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
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            // usamos cadena de conexion, declaramos como "objeto" la conexion (oconexion) como nuevo conector de sql (usamos "conexion.cadena" <- cadena: evento creado en "Conexion.cs" para unir con bd)
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    // Trae consulta
                    StringBuilder query = new StringBuilder();
                    // AppendLine: Permite dar salto de línea
                    query.AppendLine("SELECT CategoriaID, NombreCategoria, Estado FROM Categorias");
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
                            lista.Add(new Categoria()
                            {
                                //Empezamos a declarar la tabla de la Base de Datos, convirtiendo en entero32 el "CategoriaID"
                                // dr = variable donde se almacena la query, es decir, la consulta realizada (select)
                                CategoriaID = Convert.ToInt32(dr["CategoriaID"]),
                                NombreCategoria = dr["NombreCategoria"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                            });
                        }
                    }

                }
                // si hay un error, muestra una lista sin elementos (como nueva)
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }
        // Registrar
        public int Registrar(Categoria obj, out string Mensaje)
        {
            int CategoriaIDGenerada = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "RegistrarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", oconexion);
                    cmd.Parameters.AddWithValue("NombreCategoria", obj.NombreCategoria);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
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
        public bool Editar(Categoria obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EditarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", oconexion);
                    cmd.Parameters.AddWithValue("CategoriaID", obj.CategoriaID);
                    cmd.Parameters.AddWithValue("NombreCategoria", obj.NombreCategoria);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
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
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EliminarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA", oconexion);
                    cmd.Parameters.AddWithValue("CategoriaID", obj.CategoriaID);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
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
