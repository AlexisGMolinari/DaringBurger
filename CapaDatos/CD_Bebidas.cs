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
    public class CD_Bebidas
    {
        public List<Bebidas> Listar()
        {
            List<Bebidas> lista = new List<Bebidas>();

            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT b.NombreBebida, b.Precio, c.NombreCategoria, t.Tamanio, t.Envase, b.Estado FROM Bebidas b");
                    query.AppendLine("INNER JOIN Categorias c ON b.CategoriaID = c.CategoriaID");
                    query.AppendLine("INNER JOIN TamanioBebida t ON b.TamanioID = t.TamanioID WHERE c.Estado = 1 AND b.Estado = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Bebidas()
                            {
                                NombreBebida = dr["NombreBebida"].ToString(),
                                Precio = Convert.ToDecimal(dr["Precio"]),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oCategoria = new Categoria() { NombreCategoria = dr["NombreCategoria"].ToString() },
                                oTamanioBebida = new TamanioBebida() { Tamanio = dr["Tamanio"].ToString(), Envase = dr["Envase"].ToString() },
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Bebidas>();
                    // Manejar la excepción o mostrar un mensaje de error si es necesario
                }
            }

            return lista;
        }
    

    // Registrar
    public int Registrar(Bebidas obj, out string Mensaje)
        {
            int BebidaIDGenerada = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "RegistrarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARBEBIDA", oconexion);
                    cmd.Parameters.AddWithValue("NombreBebida", obj.NombreBebida);
                    cmd.Parameters.AddWithValue("Precio", obj.Precio);
                    cmd.Parameters.AddWithValue("TamanioID", obj.TamanioID);
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
                    BebidaIDGenerada = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                BebidaIDGenerada = 0;
                Mensaje = ex.Message;
            }

            return BebidaIDGenerada;
        }
        public bool Editar(Bebidas obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EditarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_EDITARBEBIDA", oconexion);
                    cmd.Parameters.AddWithValue("BebidasID", obj.BebidaID);
                    cmd.Parameters.AddWithValue("NombreBebida", obj.NombreBebida);
                    cmd.Parameters.AddWithValue("Precio", obj.Precio);
                    cmd.Parameters.AddWithValue("TamanioID", obj.TamanioID);
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
        public bool Eliminar(Bebidas obj, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
                {
                    // comando sql llamado "cmd", va a ejecutar el "Evento" creado en la DB como "EliminarCategoria"
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARBEBIDA", oconexion);
                    cmd.Parameters.AddWithValue("BebidaID", obj.BebidaID);
                    cmd.Parameters.AddWithValue("CategoriaID", obj.CategoriaID);
                    cmd.Parameters.AddWithValue("TamanioID", obj.TamanioID);
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
